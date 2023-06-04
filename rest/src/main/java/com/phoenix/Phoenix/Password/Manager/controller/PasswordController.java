package com.phoenix.Phoenix.Password.Manager.controller;

import com.phoenix.Phoenix.Password.Manager.service.password.Password;
import com.phoenix.Phoenix.Password.Manager.service.password.PasswordService;
import com.phoenix.Phoenix.Password.Manager.support.result.BusinessResultHandler;
import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import com.phoenix.Phoenix.Password.Manager.support.result.UpdateResult;
import org.springframework.http.HttpStatus;
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
    @PostMapping("/{id}")
    public ResponseEntity<?> updatePassword(@PathVariable String passwordId,@RequestBody Password password)
    {
        UpdateResult result=passwordService.updatePassword(password.getUserId(), passwordId,password);
        return BusinessResultHandler.handleResult(result);
    }
    @GetMapping("/{id}")
    public ResponseEntity<List<Password>> listPasswordsByUserId(@PathVariable String userId) {
        List<Password> passwords = passwordService.listPassword(userId);
        return ResponseEntity.ok(passwords);
    }
    @DeleteMapping("/{id}")
    public ResponseEntity<?> deleteById(@PathVariable String passwordId)
    {
        passwordService.deletePassword(passwordId);
        ResponseEntity<?> result = new ResponseEntity<>(HttpStatus.NO_CONTENT);
        return result;
    }

}
