package com.phoenix.Phoenix.Password.Manager.service.user;

import jakarta.validation.constraints.Email;

public class RequestPasswordResetServiceRequest {
    @Email
    private String email;

    public String getEmail() {
        return email;
    }

    public RequestPasswordResetServiceRequest setEmail(String email) {
        this.email = email;
        return this;
    }
}
