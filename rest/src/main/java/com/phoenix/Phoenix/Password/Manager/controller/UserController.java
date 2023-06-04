package com.phoenix.Phoenix.Password.Manager.controller;

import com.phoenix.Phoenix.Password.Manager.service.user.UserService;
import com.phoenix.Phoenix.Password.Manager.support.result.BusinessResultHandler;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping()
public class UserController {
    private final UserService userService;


    public UserController(UserService userService) {
        this.userService = userService;
    }


    @PostMapping("/auth/reset-password")
    ResponseEntity<String> requestPasswordReset(@RequestBody RequestPasswordReset request){
        String response = userService.requestPasswordReset(request.toServiceRequest());
        return ResponseEntity.ok(response);
    }

    @PutMapping("/auth/reset-password")
    ResponseEntity<?> resetPassword(@RequestBody ResetPassword reset){
        ResponseEntity<?> result = BusinessResultHandler.handleResult(userService.resetPassword(reset.toServiceRequest()));
        return result;
    }

}
