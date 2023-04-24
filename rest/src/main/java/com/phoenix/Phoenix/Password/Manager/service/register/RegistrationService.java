package com.phoenix.Phoenix.Password.Manager.service.register;

import jakarta.validation.Valid;

public interface RegistrationService {
    RegistrationResult requestRegistration(@Valid RegistrationServiceRequest request);
}
