package com.phoenix.Phoenix.Password.Manager.repositorymongodb;

import com.phoenix.Phoenix.Password.Manager.repository.ResetPasswordTokenRepository;
import com.phoenix.Phoenix.Password.Manager.support.token.ResetPasswordToken;
import org.springframework.data.repository.Repository;

@org.springframework.stereotype.Repository
public interface ResetPasswordTokenRepositoryMongoDB extends ResetPasswordTokenRepository, Repository<ResetPasswordToken,String> {
    @Override
    default void invalidateToken(String key){
        this.deleteById(key);
    }

    void deleteById(String id);

}
