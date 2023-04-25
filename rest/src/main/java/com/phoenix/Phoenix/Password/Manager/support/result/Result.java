package com.phoenix.Phoenix.Password.Manager.support.result;

public abstract class Result {
    protected Boolean isSuccess;

    protected OperationFailureReason reason;

    protected String message = "";

    public Boolean isSuccess() {
        return isSuccess;
    }

    public Result setSuccess(Boolean success) {
        isSuccess = success;
        return this;
    }

    public OperationFailureReason getReason() {
        return reason;
    }

    public Result setReason(OperationFailureReason reason) {
        this.reason = reason;
        return this;
    }

    public String getMessage() {
        return message;
    }

    public Result setMessage(String message) {
        this.message = message;
        return this;
    }
}
