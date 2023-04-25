package com.phoenix.Phoenix.Password.Manager.service.password;

import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import jakarta.validation.Valid;
import org.springframework.validation.annotation.Validated;

@Validated
public interface PasswordService {
    CreationResult<?> savePassword(@Valid Password password);

}
// he bi dakika
