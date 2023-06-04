package com.phoenix.Phoenix.Password.Manager.controller;


import com.phoenix.Phoenix.Password.Manager.service.auth.AuthenticationService;
import com.phoenix.Phoenix.Password.Manager.support.result.BusinessResultHandler;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;


@RestController
@RequestMapping("/auth")
public class AuthenticationController {

    private final AuthenticationService service;


    AuthenticationController(AuthenticationService service){
        this.service = service;
    }
    @PostMapping("/register")
    public ResponseEntity<?> register(
            @RequestBody RegistrationRequest request){

        return BusinessResultHandler.handleResult(service.register(request.toServiceRequest()));
    }

    @PutMapping("/verify")
    public ResponseEntity<?> verifyRegistration(@RequestBody VerifyAccountRequest request){
        return BusinessResultHandler.handleResult(service.verifyAccount(request.key()));
    }

    @PostMapping("/login")
    public ResponseEntity<?> requestAuth(
            @RequestBody AuthenticationRequest request)
    {
        return BusinessResultHandler.handleResult(service.authenticate(request));
    }



}
