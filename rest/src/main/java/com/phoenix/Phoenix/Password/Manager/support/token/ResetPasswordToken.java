package com.phoenix.Phoenix.Password.Manager.support.token;

import org.springframework.data.annotation.Id;

import java.time.Instant;
import java.time.temporal.ChronoUnit;

public class ResetPasswordToken {
    @Id
    private String token;

    private String userId;

    private Instant expiredAt;

    private Instant createdAt;

    private ResetPasswordToken(){}

    public String getToken() {
        return token;
    }

    public ResetPasswordToken setToken(String token) {
        this.token = token;
        return this;
    }

    public String getUserId() {
        return userId;
    }

    public ResetPasswordToken setUserId(String userId) {
        this.userId = userId;
        return this;
    }

    public Instant getExpiredAt() {
        return expiredAt;
    }

    public ResetPasswordToken setExpiredAt(Instant expiredAt) {
        this.expiredAt = expiredAt;
        return this;
    }

    public Instant getCreatedAt() {
        return createdAt;
    }

    public ResetPasswordToken setCreatedAt(Instant createdAt) {
        this.createdAt = createdAt;
        return this;
    }

    public static ResetPasswordToken generateToken(String userId){
        return new ResetPasswordToken()
                .setToken(TokenGenerator.generateTokenKey())
                .setUserId(userId)
                .setCreatedAt(Instant.now())
                .setExpiredAt(Instant.now().plus(15,ChronoUnit.MINUTES));
    }

    public boolean isExpired(){
        return expiredAt.isBefore(Instant.now());
    }

}
