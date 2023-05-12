package com.phoenix.Phoenix.Password.Manager.controller;

import com.phoenix.Phoenix.Password.Manager.service.password.Password;
import com.phoenix.Phoenix.Password.Manager.service.password.PasswordService;
import com.phoenix.Phoenix.Password.Manager.support.result.BusinessResultHandler;
import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/password")
public class PasswordController {

    private final PasswordService passwordService;

    public PasswordController(PasswordService passwordService) {
        this.passwordService = passwordService;
    }

    @PostMapping
    public ResponseEntity<?> savePassword(@RequestBody Password password)
    {
        CreationResult<?> result=passwordService.savePassword(password);
        return BusinessResultHandler.handleResult(result);
    }
    @PostMapping
    public ResponseEntity<?> updatePassword(String passwordId,Password password)
    {
        CreationResult<?> result=passwordService.updatePassword(passwordId,password);
        return BusinessResultHandler.handleResult(result);
    }
}
