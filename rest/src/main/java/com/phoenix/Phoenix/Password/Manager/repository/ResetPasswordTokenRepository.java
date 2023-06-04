package com.phoenix.Phoenix.Password.Manager.repository;

import com.phoenix.Phoenix.Password.Manager.support.token.ResetPasswordToken;

import java.util.Optional;

public interface ResetPasswordTokenRepository {
    void save(ResetPasswordToken token);

    Optional<ResetPasswordToken> getByToken(String key);

    void invalidateToken(String key);
}
