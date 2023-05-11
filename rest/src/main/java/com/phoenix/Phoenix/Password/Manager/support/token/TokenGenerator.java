package com.phoenix.Phoenix.Password.Manager.support.token;

import java.security.SecureRandom;

public class TokenGenerator {
    private static final String NUMBER_KEYS = "0123456789";
    public static String generateTokenKey(){

        StringBuilder stringBuilder = new StringBuilder();
        SecureRandom secureRandom = new SecureRandom();
        for(int i =0; i < 6; i++){
            stringBuilder.append(NUMBER_KEYS.charAt(Math.abs(secureRandom.nextInt() % 6)));
        }
        return stringBuilder.toString();
    }
}
