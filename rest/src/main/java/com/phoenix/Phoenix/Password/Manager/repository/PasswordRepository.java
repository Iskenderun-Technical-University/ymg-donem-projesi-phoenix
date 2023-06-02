package com.phoenix.Phoenix.Password.Manager.repository;

import com.mongodb.client.result.DeleteResult;
import com.phoenix.Phoenix.Password.Manager.service.password.Password;
import org.springframework.validation.annotation.Validated;

import java.util.List;
import java.util.Optional;

@Validated
public interface PasswordRepository {
    void save(Password password);

    Optional<Password> getByTitleAndUserId(String title,String userId);

    Optional<Password> getById(String id);

    Optional<Password> getByTitle(String title);

    List<Password> listByUserId(String userId);

    Optional<Password> getByUserId(String userId);

    DeleteResult deleteById(String Userid);
}
