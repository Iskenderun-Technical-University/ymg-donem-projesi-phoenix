package com.phoenix.Phoenix.Password.Manager.service.password;

import com.mongodb.client.result.DeleteResult;
import com.phoenix.Phoenix.Password.Manager.repository.PasswordRepository;
import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import com.phoenix.Phoenix.Password.Manager.support.result.OperationFailureReason;
import com.phoenix.Phoenix.Password.Manager.support.result.UpdateResult;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;
import org.springframework.util.ObjectUtils;


import java.util.*;

@Service
public class DefaultPasswordService implements PasswordService{
    private final PasswordRepository passwordRepository;

    private final PasswordEncoder passwordEncoder;
    public DefaultPasswordService(PasswordRepository passwordRepository, PasswordEncoder passwordEncoder) {
        this.passwordRepository=passwordRepository;
        this.passwordEncoder = passwordEncoder;
    }

    @Override
    public CreationResult<?> savePassword(String userId,Password password) {
        if(ObjectUtils.isEmpty(password.getTitle()))
        {
            return CreationResult.failed(OperationFailureReason.PRECONDITION_FAILED,"Title can not be empty");
        }
        Optional<Password> passwordOptional=passwordRepository.getByTitleAndUserId(password.getTitle(),userId);
        if(passwordOptional.isPresent())
        {
            return CreationResult.failed(OperationFailureReason.CONFLICT,"Title is not unique");
        }

        password.setId(UUID.randomUUID().toString());
        password.setPassword(passwordEncoder.encode(password.getPassword()));
        password.setUserId(userId);
        passwordRepository.save(password);

        return CreationResult.success(Map.of("id",password.getId()));
    }

    @Override
    public UpdateResult updatePassword(String userId,String passwordId, Password newPassword) {

        Optional<Password> passwordOptional=passwordRepository.getById(passwordId);
        if(passwordOptional.isEmpty())
        {
            return UpdateResult.failed(OperationFailureReason.PRECONDITION_FAILED,"Invalid id");
        }
         final Password oldPassword= passwordOptional.get();
        if(passwordRepository.getByTitleAndUserId(newPassword.getTitle(),userId).isPresent() && !isPasswordTitleSame(oldPassword.getTitle(),newPassword.getTitle()))
        {
            return UpdateResult.failed(OperationFailureReason.CONFLICT,"Title is already used");
        }

        final Password updatedPassword=replacePasswordFields(oldPassword,newPassword);
        passwordRepository.save(updatedPassword);
        return UpdateResult.success();
    }
    @Override
    public List<Password> listPassword(String userId) {

        Optional<Password> passwordOptional=passwordRepository.getByUserId(userId);
        if(passwordOptional.isEmpty())
        {
            return Collections.emptyList();
        }
        List<Password> passwords=passwordRepository.listByUserId(userId);
        return passwords;
    }

    @Override
    public DeleteResult deletePassword(String userId) {
        Optional<Password> passwordOptional=passwordRepository.getByUserId(userId);
        if(passwordOptional.isEmpty())
        {
            throw new IllegalArgumentException("Not found userId");
        }
       DeleteResult deleteResult= passwordRepository.deleteById(userId);
        return deleteResult;
    }

    private boolean isPasswordTitleSame(String oldTitle, String newTitle) {
        return oldTitle.equals(newTitle);
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
             newPassword.setPassword(passwordEncoder.encode(newPassword.getPassword()));
        }
        return newPassword.setId(old.getId());
    }
}
