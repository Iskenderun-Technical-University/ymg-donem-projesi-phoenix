package com.phoenix.Phoenix.Password.Manager.service.auth;

import com.phoenix.Phoenix.Password.Manager.auth.RegistrationServiceRequest;
import com.phoenix.Phoenix.Password.Manager.controller.AuthenticationRequest;
import com.phoenix.Phoenix.Password.Manager.support.result.AuthenticationResult;
import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import com.phoenix.Phoenix.Password.Manager.support.result.UpdateResult;

import java.util.Map;

public interface AuthenticationService {
    CreationResult<Map<String,String>> register(RegistrationServiceRequest request);

    AuthenticationResult<Map<String,String>> authenticate(AuthenticationRequest request);

    UpdateResult verifyAccount(String key);
}
