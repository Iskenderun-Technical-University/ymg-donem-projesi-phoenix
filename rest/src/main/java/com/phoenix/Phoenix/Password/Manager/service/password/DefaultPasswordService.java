package com.phoenix.Phoenix.Password.Manager.service.password;

import com.phoenix.Phoenix.Password.Manager.repository.PasswordRepository;
import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import com.phoenix.Phoenix.Password.Manager.support.result.OperationFailureReason;
import org.springframework.stereotype.Service;
import org.springframework.util.ObjectUtils;

import java.util.Map;
import java.util.Optional;
import java.util.UUID;

@Service
public class DefaultPasswordService implements PasswordService{
    private final PasswordRepository passwordRepository;
    public DefaultPasswordService(PasswordRepository passwordRepository) {
        this.passwordRepository=passwordRepository;
    }

    @Override
    public CreationResult<?> savePassword(Password password) {
        if(ObjectUtils.isEmpty(password.getTitle()))
        {
            return CreationResult.failed(OperationFailureReason.PRECONDITION_FAILED,"Title can not be empty");
        }
        Optional<Password> passwordOptional=passwordRepository.getByTitle(password.getTitle());
        if(passwordOptional.isPresent())
        {
            return CreationResult.failed(OperationFailureReason.CONFLICT,"Title is not unique");
        }
        password.setId(UUID.randomUUID().toString());
        passwordRepository.save(password);

        return CreationResult.success(Map.of("id",password.getId()));
    }
}
