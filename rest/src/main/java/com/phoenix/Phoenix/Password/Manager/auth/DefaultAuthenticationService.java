package com.phoenix.Phoenix.Password.Manager.auth;

import com.phoenix.Phoenix.Password.Manager.config.JwtService;
import com.phoenix.Phoenix.Password.Manager.controller.AuthenticationRequest;
import com.phoenix.Phoenix.Password.Manager.repository.AccountVerificationTokenRepository;
import com.phoenix.Phoenix.Password.Manager.repository.UserRepository;
import com.phoenix.Phoenix.Password.Manager.support.result.AuthenticationResult;
import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import com.phoenix.Phoenix.Password.Manager.support.result.OperationFailureReason;
import com.phoenix.Phoenix.Password.Manager.support.result.UpdateResult;
import com.phoenix.Phoenix.Password.Manager.support.token.AccountVerificationToken;
import com.phoenix.Phoenix.Password.Manager.support.user.Role;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;
import com.phoenix.Phoenix.Password.Manager.service.User;

import java.util.Map;
import java.util.Optional;
import java.util.UUID;

@Service
public class DefaultAuthenticationService implements AuthenticationService{

    private final UserRepository userRepository;

    private final PasswordEncoder passwordEncoder;

    private final JwtService jwtService;


    private final AccountVerificationTokenRepository tokenRepository;

    public DefaultAuthenticationService(UserRepository userRepository, PasswordEncoder passwordEncoder, JwtService jwtService,AccountVerificationTokenRepository tokenRepository) {
        this.userRepository = userRepository;
        this.passwordEncoder = passwordEncoder;
        this.jwtService = jwtService;
        this.tokenRepository = tokenRepository;
    }

    @Override
    public CreationResult<Map<String,String>> register(RegistrationServiceRequest request) {
        Optional<User> userOptional = userRepository.getByEmail(request.getEmail());
        if(userOptional.isPresent()){
            return CreationResult.failed(OperationFailureReason.CONFLICT,"Email has already registered!");
        }

        User user = new User()
                .setId(UUID.randomUUID().toString())
                .setName(request.getName())
                .setEmail(request.getEmail())
                .setVerified(false)
                .setPasswordHash(passwordEncoder.encode(request.getPassword()))
                .setRole(Role.USER);

        userRepository.save(user);
        var jwtToken = jwtService.generateToken(user);
        AccountVerificationToken token = AccountVerificationToken.generateToken(user.getId());
        tokenRepository.save(token);
        AuthenticationResponse authenticationResponse = new AuthenticationResponse().setToken(jwtToken);
        return CreationResult.success(Map.of("token",authenticationResponse.getToken()));
    }

    @Override
    public AuthenticationResult<Map<String,String>> authenticate(AuthenticationRequest request){
        Optional<User> userOptional = userRepository.findByEmail(request.getEmail());
        if(userOptional.isEmpty()){
            return AuthenticationResult.failed(OperationFailureReason.PRECONDITION_FAILED,"User not found!");
        }
        User user = userOptional.get();
        boolean isPasswordMatches = passwordEncoder.matches(request.getPassword(),user.getPasswordHash());
        if(!isPasswordMatches){
            return AuthenticationResult.failed(OperationFailureReason.UNAUTHORIZED,"Invalid credentials");
        }
        var jwtToken = jwtService.generateToken(user);
        return AuthenticationResult.success(Map.of("token",jwtToken));
    }

    @Override
    public UpdateResult verifyAccount(String key){
        Optional<AccountVerificationToken> tokenOptional = tokenRepository.getByToken(key);
        if(tokenOptional.isEmpty()){
            return UpdateResult.failed(OperationFailureReason.PRECONDITION_FAILED,"Invalid token!");
        }
        AccountVerificationToken token = tokenOptional.get();
        if(token.isExpired()){
            return UpdateResult.failed(OperationFailureReason.PRECONDITION_FAILED,"Invalid token!");
        }
        User user = userRepository.getById(token.getUserId()).orElseThrow();
        user.setVerified(true);
        userRepository.save(user);
        return UpdateResult.success();
    }
}
