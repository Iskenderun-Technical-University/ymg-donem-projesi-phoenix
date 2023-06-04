package com.phoenix.Phoenix.Password.Manager.repository;

import com.phoenix.Phoenix.Password.Manager.support.token.AccountVerificationToken;

import java.util.Optional;

public interface AccountVerificationTokenRepository {
    void save(AccountVerificationToken token);

    Optional<AccountVerificationToken> getByToken(String key);

    void invalidateToken(String key);
}
