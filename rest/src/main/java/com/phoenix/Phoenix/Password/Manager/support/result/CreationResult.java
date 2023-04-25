package com.phoenix.Phoenix.Password.Manager.support.result;

public class CreationResult<T>{

    private Boolean isSuccess;
    private T entity;
    private String message;
    private OperationFailureReason reason;

    private CreationResult(){}

    public static <T> CreationResult<T> success(T entity){
        return new CreationResult<T>()
                .setSuccess(true)
                .setEntity(entity);
    }

    public static <T> CreationResult<T> failed(OperationFailureReason reason){
        return new CreationResult<T>()
                .setReason(reason)
                .setSuccess(false);
    }

    public static <T> CreationResult<T> failed(OperationFailureReason reason,String message){
        return new CreationResult<T>()
                .setMessage(message)
                .setSuccess(false)
                .setReason(reason);
    }

    public T getEntity() {
        return entity;
    }

    public CreationResult<T> setEntity(T entity) {
        this.entity = entity;
        return this;
    }

    public Boolean isSuccess() {
        return isSuccess;
    }

    public CreationResult<T> setSuccess(Boolean success) {
        isSuccess = success;
        return this;
    }

    public String getMessage() {
        return message;
    }

    public CreationResult<T> setMessage(String message) {
        this.message = message;
        return this;
    }

    public OperationFailureReason getReason() {
        return reason;
    }

    public CreationResult<T> setReason(OperationFailureReason reason) {
        this.reason = reason;
        return this;
    }
}
