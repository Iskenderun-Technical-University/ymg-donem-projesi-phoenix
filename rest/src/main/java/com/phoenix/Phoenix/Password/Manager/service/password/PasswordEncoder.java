package com.phoenix.Phoenix.Password.Manager.service.password;

import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;

import java.security.SecureRandom;

public class PasswordEncoder {
    public static String encode(String passphrase){
        BCryptPasswordEncoder encoder = new BCryptPasswordEncoder(10,new SecureRandom());
        return encoder.encode(passphrase);
    }

}
