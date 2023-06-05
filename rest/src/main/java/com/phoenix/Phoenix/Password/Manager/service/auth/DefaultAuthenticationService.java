package com.phoenix.Phoenix.Password.Manager.service.auth;

import com.phoenix.Phoenix.Password.Manager.auth.RegistrationServiceRequest;
import com.phoenix.Phoenix.Password.Manager.config.JwtService;
import com.phoenix.Phoenix.Password.Manager.controller.AuthenticationRequest;
import com.phoenix.Phoenix.Password.Manager.repository.AccountVerificationTokenRepository;
import com.phoenix.Phoenix.Password.Manager.repository.UserRepository;
import com.phoenix.Phoenix.Password.Manager.service.user.User;
import com.phoenix.Phoenix.Password.Manager.support.email.EmailBuilder;
import com.phoenix.Phoenix.Password.Manager.support.email.EmailSender;
import com.phoenix.Phoenix.Password.Manager.support.result.AuthenticationResult;
import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import com.phoenix.Phoenix.Password.Manager.support.result.OperationFailureReason;
import com.phoenix.Phoenix.Password.Manager.support.result.UpdateResult;
import com.phoenix.Phoenix.Password.Manager.support.token.AccountVerificationToken;
import com.phoenix.Phoenix.Password.Manager.support.user.Role;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.util.Map;
import java.util.Optional;
import java.util.UUID;

@Service
public class DefaultAuthenticationService implements AuthenticationService {

    private final UserRepository userRepository;

    private final PasswordEncoder passwordEncoder;

    private final JwtService jwtService;

    private final EmailSender emailSender;


    private final AccountVerificationTokenRepository tokenRepository;

    public DefaultAuthenticationService(UserRepository userRepository, PasswordEncoder passwordEncoder, JwtService jwtService, EmailSender emailSender, AccountVerificationTokenRepository tokenRepository) {
        this.userRepository = userRepository;
        this.passwordEncoder = passwordEncoder;
        this.jwtService = jwtService;
        this.emailSender = emailSender;
        this.tokenRepository = tokenRepository;
    }

    @Override
    public CreationResult<Map<String,String>> register(RegistrationServiceRequest request) {
        Optional<User> userOptional = userRepository.getByEmail(request.getEmail());
        if(userOptional.isPresent()){
            return CreationResult.failed(OperationFailureReason.CONFLICT,"{\"message\" : \"Email has already registered!\"}");
        }

        User user = new User()
                .setId(UUID.randomUUID().toString())
                .setName(request.getName())
                .setEmail(request.getEmail())
                .setVerified(false)
                .setEnabled(true)
                .setIsLocked(false)
                .setPasswordHash(passwordEncoder.encode(request.getPassword()))
                .setRole(Role.USER);

        userRepository.save(user);
        AccountVerificationToken token = AccountVerificationToken.generateToken(user.getId());
        tokenRepository.save(token);
        emailSender.sendForAccountVerification(user.getEmail(), EmailBuilder.buildEmailForAccountVerification(user.getName(),token.getToken()));
        return CreationResult.success(Map.of("message","Instructions have been sent to email."));
    }

    @Override
    public AuthenticationResult<Map<String,String>> authenticate(AuthenticationRequest request){
        Optional<User> userOptional = userRepository.findByEmail(request.getEmail());
        if(userOptional.isEmpty()){
            return AuthenticationResult.failed(OperationFailureReason.PRECONDITION_FAILED,"{\"message\" : \"User not found!\"}");
        }
        User user = userOptional.get();
        boolean isPasswordMatches = passwordEncoder.matches(request.getPassword(),user.getPasswordHash());
        if(!isPasswordMatches){
            return AuthenticationResult.failed(OperationFailureReason.UNAUTHORIZED,"{\"message\" : \"Invalıd credentials!\"}");
        }
        var jwtToken = jwtService.generateToken(user);
        return AuthenticationResult.success(Map.of("token",jwtToken));
    }

    @Override
    public UpdateResult verifyAccount(String key){
        Optional<AccountVerificationToken> tokenOptional = tokenRepository.getByToken(key);
        if(tokenOptional.isEmpty()){
            return UpdateResult.failed(OperationFailureReason.PRECONDITION_FAILED,"{\"message\" : \"Invalid Token!\"}");
        }
        AccountVerificationToken token = tokenOptional.get();
        if(token.isExpired()){
            return UpdateResult.failed(OperationFailureReason.PRECONDITION_FAILED,"{\"message\" : \"Invalid Token!\"}");
        }
        User user = userRepository.getById(token.getUserId()).orElseThrow();
        user.setVerified(true);
        userRepository.save(user);
        tokenRepository.invalidateToken(key);
        return UpdateResult.success("{\"message\" : \"Account has been verificated.\"}");
    }
}
