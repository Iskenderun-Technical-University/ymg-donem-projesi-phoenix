package com.phoenix.Phoenix.Password.Manager.support.result;

public enum OperationFailureReason {
    CONFLICT("conflict"),
    UNAUTHORIZED("unauthorized"),
    ALREADY_DONE("already_done"),
    PRECONDITION_FAILED("precondition_failed"),
    NOT_FOUND("not-found");

    private final String value;

    OperationFailureReason(String value){
        this.value = value;
    }
}
