package com.phoenix.Phoenix.Password.Manager.service.user;

import com.phoenix.Phoenix.Password.Manager.support.result.UpdateResult;
import org.springframework.validation.annotation.Validated;

@Validated
public interface UserService {

    String requestPasswordReset(RequestPasswordResetServiceRequest email);

    UpdateResult resetPassword(UserPasswordResetServiceRequest request);
}
