package com.phoenix.Phoenix.Password.Manager.controller;

import com.mongodb.client.result.DeleteResult;
import com.phoenix.Phoenix.Password.Manager.service.password.Password;
import com.phoenix.Phoenix.Password.Manager.service.password.PasswordService;
import com.phoenix.Phoenix.Password.Manager.support.result.BusinessResultHandler;
import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import com.phoenix.Phoenix.Password.Manager.support.result.UpdateResult;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/me/password")
public class PasswordController {

    private final PasswordService passwordService;

    public PasswordController(PasswordService passwordService) {
        this.passwordService = passwordService;
    }

    @PostMapping
    public ResponseEntity<?> savePassword(@RequestBody Password password)
    {
        CreationResult<?> result=passwordService.savePassword(password.getUserId(),password);
        return BusinessResultHandler.handleResult(result);
    }
    @PostMapping
    public ResponseEntity<?> updatePassword(Password password)
    {
        UpdateResult result=passwordService.updatePassword(password.getUserId(), password.getId(),password);
        return BusinessResultHandler.handleResult(result);
    }
    @PostMapping
    public ResponseEntity<List<Password>> listPasswordsByUserId(@PathVariable String userId) {
        List<Password> passwords = passwordService.listPassword(userId);
        return ResponseEntity.ok(passwords);
    }
    @DeleteMapping
    public DeleteResult deleteById(@PathVariable String userId)
    {
        return  passwordService.deletePassword(userId);
    }

}
