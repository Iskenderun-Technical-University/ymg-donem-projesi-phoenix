package com.phoenix.Phoenix.Password.Manager.repository;

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

    List<Password> findByUserId(String userId);

    Optional<Password> getByUserId(String userId);

    void deleteById(String passwordId);
}
