package com.phoenix.Phoenix.Password.Manager.service.user;

import com.phoenix.Phoenix.Password.Manager.repository.ResetPasswordTokenRepository;
import com.phoenix.Phoenix.Password.Manager.repository.UserRepository;
import com.phoenix.Phoenix.Password.Manager.support.email.EmailBuilder;
import com.phoenix.Phoenix.Password.Manager.support.email.EmailSender;
import com.phoenix.Phoenix.Password.Manager.support.result.OperationFailureReason;
import com.phoenix.Phoenix.Password.Manager.support.result.UpdateResult;
import com.phoenix.Phoenix.Password.Manager.support.token.ResetPasswordToken;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.util.Optional;

@Service
public class DefaultUserService implements UserService{
    private final UserRepository userRepository;

    private final ResetPasswordTokenRepository tokenRepository;

    private final EmailSender emailSender;

    private final PasswordEncoder passwordEncoder;

    public DefaultUserService(UserRepository userRepository, ResetPasswordTokenRepository tokenRepository, EmailSender emailSender, PasswordEncoder passwordEncoder) {
        this.userRepository = userRepository;
        this.tokenRepository = tokenRepository;
        this.emailSender = emailSender;
        this.passwordEncoder = passwordEncoder;
    }


    @Override
    public String requestPasswordReset(RequestPasswordResetServiceRequest request) {
        final Optional<User> userOptional = userRepository.getByEmail(request.getEmail());
        if(userOptional.isEmpty()){
            return "{\"message\" : \"User not found.\"}";
        }
        final User user = userOptional.get();
        if(!user.isEnabled()){
            return "{\"message\" : \"User not found.\"}";
        }
        ResetPasswordToken token = ResetPasswordToken.generateToken(user.getId());
        tokenRepository.save(token);
        emailSender.sendForResetPassword(user.getEmail(), EmailBuilder.buildEmailForResetPassword(user.getName(),token.getToken()));
        return "{\"message\" : \"Instructions has been sent to email.\"}";
    }

    @Override
    public UpdateResult resetPassword(UserPasswordResetServiceRequest request) {
        final Optional<ResetPasswordToken> tokenOptional = tokenRepository.getByToken(request.getKey());
        if(tokenOptional.isEmpty()){
            return UpdateResult.failed(OperationFailureReason.NOT_FOUND,"{\"message\" : \"Invalid Token!\"}");
        }
        final ResetPasswordToken token = tokenOptional.get();
        final Optional<User> userOptional = userRepository.getById(token.getUserId());

        if(userOptional.isEmpty()){
            return UpdateResult.failed(OperationFailureReason.NOT_FOUND,"{\"message\" : \"Invalid Token!\"}");
        }
        final User user = userOptional.get();
        String hashedNewPassword = passwordEncoder.encode(request.getPassword());
        user.setPasswordHash(hashedNewPassword);
        userRepository.save(user);
        tokenRepository.invalidateToken(request.getKey());
        return UpdateResult.success("{\"message\" : \"Password has been reset succesfully!\"}");

    }
}
