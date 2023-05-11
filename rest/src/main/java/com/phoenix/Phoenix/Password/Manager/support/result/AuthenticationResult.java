package com.phoenix.Phoenix.Password.Manager.support.result;

public class AuthenticationResult<T>{

    private Boolean isSuccess;
    private T entity;
    private String message;
    private OperationFailureReason reason;

    private AuthenticationResult(){}

    public static <T> AuthenticationResult<T> success(T entity){
        return new AuthenticationResult<T>()
                .setSuccess(true)
                .setEntity(entity);
    }

    public static <T> AuthenticationResult<T> failed(OperationFailureReason reason){
        return new AuthenticationResult<T>()
                .setReason(reason)
                .setSuccess(false);
    }

    public static <T> AuthenticationResult<T> failed(OperationFailureReason reason, String message){
        return new AuthenticationResult<T>()
                .setMessage(message)
                .setSuccess(false)
                .setReason(reason);
    }

    public T getEntity() {
        return entity;
    }

    public AuthenticationResult<T> setEntity(T entity) {
        this.entity = entity;
        return this;
    }

    public Boolean isSuccess() {
        return isSuccess;
    }

    public AuthenticationResult<T> setSuccess(Boolean success) {
        isSuccess = success;
        return this;
    }

    public String getMessage() {
        return message;
    }

    public AuthenticationResult<T> setMessage(String message) {
        this.message = message;
        return this;
    }

    public OperationFailureReason getReason() {
        return reason;
    }

    public AuthenticationResult<T> setReason(OperationFailureReason reason) {
        this.reason = reason;
        return this;
    }
}
