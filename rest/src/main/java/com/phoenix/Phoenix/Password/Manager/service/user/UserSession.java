package com.phoenix.Phoenix.Password.Manager.service.user;

import org.springframework.stereotype.Component;

@Component
public class UserSession {
    private static String userEmail;

    private static String userId;

    public static String getUserEmail() {
        return userEmail;
    }

    public static void setUserEmail(String userEmail) {
        UserSession.userEmail = userEmail;
    }

    public static String getUserId(){
        return userId;
    }
    public static void setUserId(String userId){
        UserSession.userId = userId;
    }
}

