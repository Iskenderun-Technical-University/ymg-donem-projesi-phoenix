package com.phoenix.Phoenix.Password.Manager.repository;

import com.phoenix.Phoenix.Password.Manager.service.password.Password;
import org.springframework.validation.annotation.Validated;

import java.util.Optional;

@Validated
public interface PasswordRepository {
    void save(Password password);

    Optional<Password> getByTitle(String title);

}
