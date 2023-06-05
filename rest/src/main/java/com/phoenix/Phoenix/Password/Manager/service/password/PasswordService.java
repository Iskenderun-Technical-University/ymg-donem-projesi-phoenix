package com.phoenix.Phoenix.Password.Manager.service.password;
import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import com.phoenix.Phoenix.Password.Manager.support.result.UpdateResult;
import jakarta.validation.Valid;
import org.springframework.validation.annotation.Validated;

import java.util.List;


@Validated
public interface PasswordService {
    CreationResult<?> savePassword(String userId,@Valid Password password);

    UpdateResult updatePassword(String userId,String passwordId, @Valid Password password);


    List<Password> listPassword(String userId);

   void deletePassword(String userId,String passwordId);


    Password getPasswordById(String userId, String passwordId);
}

