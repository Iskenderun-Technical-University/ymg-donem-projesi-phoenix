package com.phoenix.Phoenix.Password.Manager.service.register;
import com.phoenix.Phoenix.Password.Manager.support.result.CreationResult;
import jakarta.validation.Valid;
import org.springframework.validation.annotation.Validated;

@Validated
public interface RegistrationService {
    CreationResult<?> requestRegistration(@Valid RegistrationServiceRequest request);
}
