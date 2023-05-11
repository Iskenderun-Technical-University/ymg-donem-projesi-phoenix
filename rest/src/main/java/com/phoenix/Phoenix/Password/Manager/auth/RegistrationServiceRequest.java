package com.phoenix.Phoenix.Password.Manager.auth;

import jakarta.validation.constraints.Email;
import org.hibernate.validator.constraints.Length;

public class RegistrationServiceRequest {
    @Email
    private String email;

    @Length(min = 6)
    private String password;

    private String name;

    public String getEmail() {
        return email;
    }

    public RegistrationServiceRequest setEmail(String email) {
        this.email = email;
        return this;
    }

    public String getPassword() {
        return password;
    }

    public RegistrationServiceRequest setPassword(String password) {
        this.password = password;
        return this;
    }

    public String getName() {
        return name;
    }

    public RegistrationServiceRequest setName(String name) {
        this.name = name;
        return this;
    }
}
