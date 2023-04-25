package com.phoenix.Phoenix.Password.Manager.support.result;

import org.springframework.http.HttpStatus;
import org.springframework.web.client.HttpClientErrorException;

public class BusinessResultHandler{
    public static void handleResult(CreationResult<?> result){
        if(!result.isSuccess()){
            if(result.getReason() == OperationFailureReason.CONFLICT){
                throw new HttpClientErrorException(HttpStatus.CONFLICT,"Conflict error!");
            }
            else if(result.getReason() == OperationFailureReason.ALREADY_DONE){
                throw new HttpClientErrorException(HttpStatus.CONFLICT,"This request has been already done.");
            }
            else if(result.getReason() == OperationFailureReason.PRECONDITION_FAILED){
                throw new HttpClientErrorException(HttpStatus.PRECONDITION_FAILED,"Title can't be null");
            }
            else if(result.getReason() == OperationFailureReason.UNAUTHORIZED){
                throw new HttpClientErrorException(HttpStatus.UNAUTHORIZED,"Unauthorized client.");
            }
        }
    }
}

