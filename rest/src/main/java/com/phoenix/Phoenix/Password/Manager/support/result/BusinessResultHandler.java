package com.phoenix.Phoenix.Password.Manager.support.result;

import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;

public class BusinessResultHandler{

    public static ResponseEntity<?> handleResult(CreationResult<?> result) {
        if(!result.isSuccess()){
            ResponseEntity<String> result1 = handleFailureReason(result.getReason(), result.getMessage());
            if (result1 != null) return result1;
        }
            return new ResponseEntity<>(result.getEntity(),HttpStatus.CREATED);
    }

    public static ResponseEntity<?> handleResult(UpdateResult result) {
        if(!result.isSuccess()){
            ResponseEntity<String> result1 = handleFailureReason(result.getReason(), result.getMessage());
            if (result1 != null) return result1;
        }
        return new ResponseEntity<>(result.getMessage(),HttpStatus.OK);
    }

    private static ResponseEntity<String> handleFailureReason(OperationFailureReason result, String result1) {
        if (result == OperationFailureReason.CONFLICT) {
            return new ResponseEntity<>(result1, HttpStatus.CONFLICT);
        } else if (result == OperationFailureReason.UNAUTHORIZED) {
            return new ResponseEntity<>(result1, HttpStatus.UNAUTHORIZED);
        } else if (result == OperationFailureReason.PRECONDITION_FAILED) {
            return new ResponseEntity<>(result1, HttpStatus.PRECONDITION_FAILED);
        } else if (result == OperationFailureReason.ALREADY_DONE) {
            return new ResponseEntity<>(result1, HttpStatus.ALREADY_REPORTED);
        }
        return null;
    }

    public static ResponseEntity<?> handleResult(AuthenticationResult<?> result) {
        if(!result.isSuccess()){
            ResponseEntity<String> result1 = handleFailureReason(result.getReason(), result.getMessage());
            if (result1 != null) return result1;
        }
        return new ResponseEntity<>(result.getEntity(),HttpStatus.CREATED);
    }
}

