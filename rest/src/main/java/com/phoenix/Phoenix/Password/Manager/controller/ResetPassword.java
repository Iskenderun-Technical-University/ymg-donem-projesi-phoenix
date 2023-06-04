package com.phoenix.Phoenix.Password.Manager.controller;

import com.phoenix.Phoenix.Password.Manager.service.user.UserPasswordResetServiceRequest;
import org.hibernate.validator.constraints.Length;

public record ResetPassword(
        @Length(min = 5)
        String code,
        String password
) {
    UserPasswordResetServiceRequest toServiceRequest(){
        return new UserPasswordResetServiceRequest()
                .setKey(code)
                .setPassword(password);
    }
}
