package com.phoenix.Phoenix.Password.Manager.support.email;

public interface EmailSender {
    void sendForAccountVerification(String to, String email);
    void sendForResetPassword(String to, String email);
}
