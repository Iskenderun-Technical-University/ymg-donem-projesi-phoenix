package com.phoenix.Phoenix.Password.Manager.service.password;

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

    public DefaultPasswordService(PasswordRepository passwordRepository) {
        this.passwordRepository=passwordRepository;
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
    public List<Password>  listPassword(String userId) {

        List<Password> passwords=passwordRepository.findByUserId(userId);
        if(passwords.isEmpty()){
            return Collections.emptyList();
        }
        for(Password p : passwords){
            p.setPassword("*".repeat(p.getPassword().length()));
        }
        return passwords;
    }

    @Override
    public void deletePassword(String userId,String passwordId) {
        final Optional<Password> passwordOptional=passwordRepository.getById(passwordId);
        if(passwordOptional.isEmpty()) {
            return;
        }
        final Password password = passwordOptional.get();
        if(password.getUserId().equals(userId)){
            passwordRepository.deleteById(passwordId);
        }

    }

    @Override
    public Password getPasswordById(String userId, String passwordId,boolean reveal) {
        final Optional<Password> passwordOptional = passwordRepository.getById(passwordId);
        if(passwordOptional.isEmpty()){
            return null;
        }
        final Password password = passwordOptional.get();
        if(password.getUserId().equals(userId)){
            if(reveal){
               return new Password(password);
            }else{
                return new Password(password).setPassword("*".repeat(password.getPassword().length()));
            }

        }else{
            return null;
        }
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
        return newPassword.setId(old.getId()).setUserId(old.getUserId());
    }
}
