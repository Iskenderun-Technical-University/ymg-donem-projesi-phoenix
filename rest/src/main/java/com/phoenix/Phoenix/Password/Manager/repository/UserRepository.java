package com.phoenix.Phoenix.Password.Manager.repository;

import com.phoenix.Phoenix.Password.Manager.service.user.User;
import jakarta.validation.constraints.Email;
import org.springframework.validation.annotation.Validated;

import java.util.Optional;

@Validated
public interface UserRepository {
    void save(User user);

    Optional<User> getByEmail(@Email String email);

    Optional<User> findByEmail(String username);

    Optional<User> getById(String userId);
}
