package com.phoenix.Phoenix.Password.Manager.service.user;

import org.hibernate.validator.constraints.Length;

public class UserPasswordResetServiceRequest {
    private String key;
    @Length(min = 6)
    private String password;

    public String getKey() {
        return key;
    }

    public UserPasswordResetServiceRequest setKey(String key) {
        this.key = key;
        return this;
    }

    public String getPassword() {
        return password;
    }

    public UserPasswordResetServiceRequest setPassword(String password) {
        this.password = password;
        return this;
    }
}
