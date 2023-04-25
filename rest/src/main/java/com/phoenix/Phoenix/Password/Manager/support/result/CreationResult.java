package com.phoenix.Phoenix.Password.Manager.support.result;

public class CreationResult<T> extends Result{
    private T entity;

    public T getEntity() {
        return entity;
    }

    public CreationResult<T> setEntity(T entity) {
        this.entity = entity;
        return this;
    }

}
