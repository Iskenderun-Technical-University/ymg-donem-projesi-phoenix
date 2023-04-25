package com.phoenix.Phoenix.Password.Manager.service;

import jakarta.validation.constraints.Email;
import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.index.Indexed;

public class User {

    public User(){}

    public User(User user){
        this.id = user.id;
        this.name = user.name;
        this.email = user.email;
        this.passwordHash = user.passwordHash;
    }

    @Id
    private String id;

    private String name;

    @Email
    @Indexed(name = "email")
    private String email;

    private String passwordHash;

    private Boolean isVerified;
    private Boolean isEnabled;

    public Boolean getVerified() {
        return isVerified;
    }

    public User setVerified(Boolean verified) {
        isVerified = verified;
        return this;
    }

    public Boolean getEnabled() {
        return isEnabled;
    }

    public User setEnabled(Boolean enabled) {
        isEnabled = enabled;
        return this;
    }

    public String getId() {
        return id;
    }

    public User setId(String id) {
        this.id = id;
        return this;
    }

    public String getName() {
        return name;
    }

    public User setName(String name) {
        this.name = name;
        return this;
    }

    public String getEmail() {
        return email;
    }

    public User setEmail(String email) {
        this.email = email;
        return this;
    }

    public String getPasswordHash() {
        return passwordHash;
    }

    public User setPasswordHash(String passwordHash) {
        this.passwordHash = passwordHash;
        return this;
    }
}
