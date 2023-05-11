package com.phoenix.Phoenix.Password.Manager.controller;

import com.phoenix.Phoenix.Password.Manager.auth.RegistrationServiceRequest;
import jakarta.validation.constraints.Email;
import org.hibernate.validator.constraints.Length;

public record RegistrationRequest(
    @Email
    String email,
    @Length(min=6)
    String password,
    String name
) {
    RegistrationServiceRequest toServiceRequest(){
        return new RegistrationServiceRequest()
                .setEmail(this.email)
                .setPassword(this.password)
                .setName(this.name);
    }

}
