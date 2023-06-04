package com.phoenix.Phoenix.Password.Manager.support.email;

import jakarta.mail.MessagingException;
import jakarta.mail.internet.MimeMessage;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.mail.javamail.JavaMailSender;
import org.springframework.mail.javamail.MimeMessageHelper;
import org.springframework.scheduling.annotation.Async;
import org.springframework.stereotype.Service;

@Service
public class EmailService implements EmailSender{

    private final static Logger logger = LoggerFactory.getLogger(EmailService.class);
    private final JavaMailSender javaMailSender;

    EmailService(JavaMailSender javaMailSender){
        this.javaMailSender = javaMailSender;
    }

    @Override
    @Async
    public void sendForAccountVerification(String to, String email) {
        try {
            MimeMessage mimeMessage = javaMailSender.createMimeMessage();
            MimeMessageHelper mimeMessageHelper = new MimeMessageHelper(mimeMessage,"utf-8");
            mimeMessageHelper.setText(email,true);
            mimeMessageHelper.setTo(to);
            mimeMessageHelper.setSubject("Confirmation Code");
            mimeMessageHelper.setFrom("no-reply@phoenix.com");
            javaMailSender.send(mimeMessage);
        }catch (MessagingException e){
            logger.error("Failed to send email!");
        }
    }

    @Override
    @Async
    public void sendForResetPassword(String to, String email) {
        try {
            MimeMessage mimeMessage = javaMailSender.createMimeMessage();
            MimeMessageHelper mimeMessageHelper = new MimeMessageHelper(mimeMessage,"utf-8");
            mimeMessageHelper.setText(email,true);
            mimeMessageHelper.setTo(to);
            mimeMessageHelper.setSubject("Password Reset Code");
            mimeMessageHelper.setFrom("no-reply@phoenix.com");
            javaMailSender.send(mimeMessage);
        }catch (MessagingException e){
            logger.error("Failed to send email!");
        }
    }
}
