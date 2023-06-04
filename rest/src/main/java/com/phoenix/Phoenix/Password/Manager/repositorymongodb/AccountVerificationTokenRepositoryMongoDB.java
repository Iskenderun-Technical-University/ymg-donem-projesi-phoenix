package com.phoenix.Phoenix.Password.Manager.repositorymongodb;

import com.phoenix.Phoenix.Password.Manager.repository.AccountVerificationTokenRepository;
import com.phoenix.Phoenix.Password.Manager.support.token.AccountVerificationToken;
import org.springframework.data.repository.Repository;

@org.springframework.stereotype.Repository
public interface AccountVerificationTokenRepositoryMongoDB extends AccountVerificationTokenRepository, Repository<AccountVerificationToken,String> {
    @Override
    default void invalidateToken(String key){
        this.deleteById(key);
    }

    void deleteById(String id);

}
