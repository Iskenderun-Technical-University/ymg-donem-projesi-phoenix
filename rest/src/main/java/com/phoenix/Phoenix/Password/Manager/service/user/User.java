package com.phoenix.Phoenix.Password.Manager.service.user;

import com.phoenix.Phoenix.Password.Manager.support.user.Role;
import jakarta.validation.constraints.Email;
import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.index.Indexed;
import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.core.userdetails.UserDetails;

import java.util.Collection;
import java.util.Collections;

public class User implements UserDetails {

    private Role role;

    private boolean isEnabled;

    private boolean isLocked;

    @Override
    public Collection<? extends GrantedAuthority> getAuthorities() {
        return Collections.singleton(new SimpleGrantedAuthority(role.name()));
    }

    @Override
    public boolean isAccountNonExpired() {
        return true;
    }

    @Override
    public boolean isAccountNonLocked() {
        return isLocked;
    }

    @Override
    public boolean isCredentialsNonExpired() {
        return true;
    }

    @Override
    public boolean isEnabled() {
        return isEnabled;
    }

    public User(){}


    @Override
    public String getUsername() {
        return email;
    }

    @Override
    public String getPassword() {
        return passwordHash;
    }

    public User(User user){
        this.id = user.id;
        this.name = user.name;
        this.email = user.email;
        this.passwordHash = user.passwordHash;
        this.isEnabled = user.isEnabled;
        this.isLocked = user.isLocked;
        this.isVerified = user.isVerified;
        this.role = user.role;
    }

    public Role getRole(){
        return this.role;
    }

    public User setRole(Role role){
        this.role = role;
        return this;
    }

    public User setIsLocked(boolean isLocked){
        this.isLocked = isLocked;
        return this;
    }

    public User setIsEnabled(boolean isEnabled){
        this.isEnabled = isEnabled;
        return this;
    }

    @Id
    private String id;

    private String name;

    @Email
    @Indexed(name = "email")
    private String email;

    private String passwordHash;

    private Boolean isVerified;

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
