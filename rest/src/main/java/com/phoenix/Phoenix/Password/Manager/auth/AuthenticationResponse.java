package com.phoenix.Phoenix.Password.Manager.auth;

public class AuthenticationResponse {
    public String getToken() {
        return token;
    }

    public AuthenticationResponse setToken(String token) {
        this.token = token;
        return this;
    }

    private String token;
}
