package com.phoenix.Phoenix.Password.Manager.controller;

import com.phoenix.Phoenix.Password.Manager.service.password.Password;
import com.phoenix.Phoenix.Password.Manager.service.password.PasswordService;
import com.phoenix.Phoenix.Password.Manager.service.user.UserSession;
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
        CreationResult<?> result=passwordService.savePassword(UserSession.getUserId(),password);
        return BusinessResultHandler.handleResult(result);
    }
    @PostMapping(value = "/{id}")
    public ResponseEntity<?> updatePassword(@PathVariable("id") String passwordId,@RequestBody Password password)
    {
        UpdateResult result=passwordService.updatePassword(UserSession.getUserId(), passwordId,password);
        return BusinessResultHandler.handleResult(result);
    }
    @GetMapping()
    public List<Password> listPasswordsByUserId() {
        return passwordService.listPassword(UserSession.getUserId());
    }

    @GetMapping("/{id}")
    public ResponseEntity<Password> getPassword(@PathVariable("id") String passwordId){
        Password password = passwordService.getPasswordById(UserSession.getUserId(),passwordId);
        if(password == null){
            return ResponseEntity.notFound().build();
        }
        return ResponseEntity.ok(password);
    }

    @DeleteMapping(value = "/{id}")
    public ResponseEntity<?> deleteById(@PathVariable("id") String passwordId)
    {
        passwordService.deletePassword(UserSession.getUserId(),passwordId);
        return new ResponseEntity<>(HttpStatus.NO_CONTENT);
    }

}
