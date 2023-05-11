package com.phoenix.Phoenix.Password.Manager.controller;

import org.hibernate.validator.constraints.Length;

public record VerifyAccountRequest(
        @Length(min = 6)
        String key
) {
}
