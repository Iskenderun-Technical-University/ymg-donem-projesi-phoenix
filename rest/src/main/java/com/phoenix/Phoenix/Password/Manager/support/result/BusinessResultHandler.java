package com.phoenix.Phoenix.Password.Manager.support.result;

import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;

public class BusinessResultHandler{

    public static ResponseEntity<?> handleResult(CreationResult<?> result) {
        if(!result.isSuccess()){
            if(result.getReason() == OperationFailureReason.CONFLICT){
                return new ResponseEntity<>(result.getMessage(),HttpStatus.CONFLICT);
            }else if(result.getReason() == OperationFailureReason.UNAUTHORIZED){
                return new ResponseEntity<>(result.getMessage(),HttpStatus.UNAUTHORIZED);
            }else if(result.getReason() == OperationFailureReason.PRECONDITION_FAILED){
                return new ResponseEntity<>(result.getMessage(),HttpStatus.PRECONDITION_FAILED);
            }else if(result.getReason() == OperationFailureReason.ALREADY_DONE){
                return new ResponseEntity<>(result.getMessage(),HttpStatus.ALREADY_REPORTED);
            }
        }
            return new ResponseEntity<>(result.getEntity(),HttpStatus.CREATED);
    }
}

