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

    @Override
    public CreationResult<?> updatePassword(String passwordId,Password newPassword) {

        Optional<Password> passwordOptional=passwordRepository.getById(passwordId);
        if(passwordOptional.isEmpty())
        {
            return CreationResult.failed(OperationFailureReason.PRECONDITION_FAILED,"Invalid id");
        }
         final Password oldPassword= passwordOptional.get();
        if(passwordRepository.getByTitle(newPassword.getTitle()).isPresent())
        {
            return CreationResult.failed(OperationFailureReason.CONFLICT,"Title is already used");
        }
        final Password updatedPassword=replacePasswordFields(oldPassword,newPassword);
        passwordRepository.save(updatedPassword);
        return CreationResult.success(null);


    }

    private Password replacePasswordFields(Password old,Password newPassword)
    {
        if(ObjectUtils.isEmpty(newPassword.getTitle()))
        {
            newPassword.setTitle(old.getTitle());
        }
        if(ObjectUtils.isEmpty(newPassword.getUsername()))
        {
            newPassword.setUsername(old.getUsername());
        }
        if(ObjectUtils.isEmpty(newPassword.getNotes()))
        {
            newPassword.setNotes(old.getNotes());
        }
        if(ObjectUtils.isEmpty(newPassword.getUrl()))
        {
            newPassword.setUrl(old.getUrl());
        }
        if(ObjectUtils.isEmpty(newPassword.getPassword()))
        {
            newPassword.setPassword(old.getPassword());
        }
        else
        {
             newPassword.setPassword(PasswordEncoder.encode(newPassword.getPassword()));
        }
        return newPassword.setId(old.getId());
    }
}
