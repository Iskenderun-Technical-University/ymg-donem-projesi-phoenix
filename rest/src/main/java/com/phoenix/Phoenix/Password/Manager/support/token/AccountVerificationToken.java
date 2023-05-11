package com.phoenix.Phoenix.Password.Manager.support.token;

import org.springframework.data.annotation.Id;

import java.time.Instant;
import java.time.temporal.ChronoUnit;

public class AccountVerificationToken {
    @Id
    private String token;

    private String userId;

    private Instant expiredAt;

    private Instant createdAt;

    private AccountVerificationToken(){}

    public String getToken() {
        return token;
    }

    public AccountVerificationToken setToken(String token) {
        this.token = token;
        return this;
    }

    public String getUserId() {
        return userId;
    }

    public AccountVerificationToken setUserId(String userId) {
        this.userId = userId;
        return this;
    }

    public Instant getExpiredAt() {
        return expiredAt;
    }

    public AccountVerificationToken setExpiredAt(Instant expiredAt) {
        this.expiredAt = expiredAt;
        return this;
    }

    public Instant getCreatedAt() {
        return createdAt;
    }

    public AccountVerificationToken setCreatedAt(Instant createdAt) {
        this.createdAt = createdAt;
        return this;
    }

    public static AccountVerificationToken generateToken(String userId){
        return new AccountVerificationToken()
                .setToken(TokenGenerator.generateTokenKey())
                .setUserId(userId)
                .setCreatedAt(Instant.now())
                .setExpiredAt(Instant.now().plus(15,ChronoUnit.MINUTES));
    }

    public boolean isExpired(){
        return expiredAt.isBefore(Instant.now());
    }

}
