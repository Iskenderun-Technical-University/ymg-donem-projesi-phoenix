package com.phoenix.Phoenix.Password.Manager.controller;

import com.phoenix.Phoenix.Password.Manager.service.register.RegistrationService;
import com.phoenix.Phoenix.Password.Manager.support.result.BusinessResultHandler;
import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/register")
public class RegistrationController {

    private final RegistrationService registrationService;

    RegistrationController(RegistrationService registrationService){
        this.registrationService = registrationService;
    }

    @PostMapping
    public ResponseEntity<?> register(@RequestBody RegistrationRequest request){
        CreationResult<?> result = registrationService.requestRegistration(request.toServiceRequest());
        return BusinessResultHandler.handleResult(result);
    }

}
