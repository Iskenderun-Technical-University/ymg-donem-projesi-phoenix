package com.phoenix.Phoenix.Password.Manager.controller;

import com.phoenix.Phoenix.Password.Manager.service.user.RequestPasswordResetServiceRequest;
import jakarta.validation.constraints.Email;

public record RequestPasswordReset(
        @Email
        String email
) {


    public RequestPasswordResetServiceRequest toServiceRequest() {
        return new RequestPasswordResetServiceRequest().setEmail(email);
    }
}
