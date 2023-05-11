package com.phoenix.Phoenix.Password.Manager.auth;

import com.phoenix.Phoenix.Password.Manager.config.JwtService;
import com.phoenix.Phoenix.Password.Manager.controller.AuthenticationRequest;
import com.phoenix.Phoenix.Password.Manager.repository.AccountVerificationTokenRepository;
import com.phoenix.Phoenix.Password.Manager.repository.UserRepository;
import com.phoenix.Phoenix.Password.Manager.support.email.EmailSender;
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
        emailSender.send(user.getEmail(),buildEmail(user.getName(),token.getToken()));
        AuthenticationResponse authenticationResponse = new AuthenticationResponse().setToken(jwtToken);
        return CreationResult.success(Map.of("token",authenticationResponse.getToken()));
    }

    private String buildEmail(String name, String code) {
        return "<div style=\"font-family:Helvetica,Arial,sans-serif;font-size:16px;margin:0;color:#0b0c0c\">\n" +
                "\n" +
                "<span style=\"display:none;font-size:1px;color:#fff;max-height:0\"></span>\n" +
                "\n" +
                "  <table role=\"presentation\" width=\"100%\" style=\"border-collapse:collapse;min-width:100%;width:100%!important\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\">\n" +
                "    <tbody><tr>\n" +
                "      <td width=\"100%\" height=\"53\" bgcolor=\"#0b0c0c\">\n" +
                "        \n" +
                "        <table role=\"presentation\" width=\"100%\" style=\"border-collapse:collapse;max-width:580px\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" align=\"center\">\n" +
                "          <tbody><tr>\n" +
                "            <td width=\"70\" bgcolor=\"#0b0c0c\" valign=\"middle\">\n" +
                "                <table role=\"presentation\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" style=\"border-collapse:collapse\">\n" +
                "                  <tbody><tr>\n" +
                "                    <td style=\"padding-left:10px\">\n" +
                "                  \n" +
                "                    </td>\n" +
                "                    <td style=\"font-size:28px;line-height:1.315789474;Margin-top:4px;padding-left:10px\">\n" +
                "                      <span style=\"font-family:Helvetica,Arial,sans-serif;font-weight:700;color:#ffffff;text-decoration:none;vertical-align:top;display:inline-block\">Confirm your email</span>\n" +
                "                    </td>\n" +
                "                  </tr>\n" +
                "                </tbody></table>\n" +
                "              </a>\n" +
                "            </td>\n" +
                "          </tr>\n" +
                "        </tbody></table>\n" +
                "        \n" +
                "      </td>\n" +
                "    </tr>\n" +
                "  </tbody></table>\n" +
                "  <table role=\"presentation\" class=\"m_-6186904992287805515content\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" style=\"border-collapse:collapse;max-width:580px;width:100%!important\" width=\"100%\">\n" +
                "    <tbody><tr>\n" +
                "      <td width=\"10\" height=\"10\" valign=\"middle\"></td>\n" +
                "      <td>\n" +
                "        \n" +
                "                <table role=\"presentation\" width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" style=\"border-collapse:collapse\">\n" +
                "                  <tbody><tr>\n" +
                "                    <td bgcolor=\"#1D70B8\" width=\"100%\" height=\"10\"></td>\n" +
                "                  </tr>\n" +
                "                </tbody></table>\n" +
                "        \n" +
                "      </td>\n" +
                "      <td width=\"10\" valign=\"middle\" height=\"10\"></td>\n" +
                "    </tr>\n" +
                "  </tbody></table>\n" +
                "\n" +
                "\n" +
                "\n" +
                "  <table role=\"presentation\" class=\"m_-6186904992287805515content\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" style=\"border-collapse:collapse;max-width:580px;width:100%!important\" width=\"100%\">\n" +
                "    <tbody><tr>\n" +
                "      <td height=\"30\"><br></td>\n" +
                "    </tr>\n" +
                "    <tr>\n" +
                "      <td width=\"10\" valign=\"middle\"><br></td>\n" +
                "      <td style=\"font-family:Helvetica,Arial,sans-serif;font-size:19px;line-height:1.315789474;max-width:560px\">\n" +
                "        \n" +
                "            <p style=\"Margin:0 0 20px 0;font-size:19px;line-height:25px;color:#0b0c0c\">Hi " + name + ",</p><p style=\"Margin:0 0 20px 0;font-size:19px;line-height:25px;color:#0b0c0c\"> Thank you for registering. Please click on the below link to activate your account: </p><blockquote style=\"Margin:0 0 20px 0;border-left:10px solid #b1b4b6;padding:15px 0 0.1px 15px;font-size:19px;line-height:25px\"><p style=\"Margin:0 0 20px 0;font-size:19px;line-height:25px;color:#0b0c0c\"> <p>" + code + "</p> </p></blockquote>\n Link will expire in 15 minutes. <p>See you soon</p>" +
                "        \n" +
                "      </td>\n" +
                "      <td width=\"10\" valign=\"middle\"><br></td>\n" +
                "    </tr>\n" +
                "    <tr>\n" +
                "      <td height=\"30\"><br></td>\n" +
                "    </tr>\n" +
                "  </tbody></table><div class=\"yj6qo\"></div><div class=\"adL\">\n" +
                "\n" +
                "</div></div>";
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
