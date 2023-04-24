package com.phoenix.Phoenix.Password.Manager.controller;

import com.phoenix.Phoenix.Password.Manager.service.register.RegistrationService;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;

import java.util.Map;
import java.util.concurrent.Callable;

@RestController
@RequestMapping("/register")
public class RegistrationController {

    private RegistrationService registrationService;

    RegistrationController(RegistrationService registrationService){
        this.registrationService = registrationService;
    }

    @PostMapping
    @ResponseStatus(HttpStatus.CREATED)
    public Callable<?> register(@RequestBody RegistrationRequest request){
        return () -> {
            registrationService.requestRegistration(request.toServiceRequest());
            return Map.of("message","Successfully registered.");
        };
    }

}
