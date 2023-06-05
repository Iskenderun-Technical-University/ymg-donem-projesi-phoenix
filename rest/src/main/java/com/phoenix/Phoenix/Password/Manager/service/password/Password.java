package com.phoenix.Phoenix.Password.Manager.service.password;

import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.index.Indexed;

public class Password {
    @Id
    private String id;

    private String userId;
    private String username;
    @Indexed(name="title")
    private String title;
    private String notes;
    private String url;
    private String password;

    public Password(Password p){
        this.id = p.id;
        this.userId = p.userId;
        this.username = p.username;
        this.password = p.password;
        this.title = p.title;
        this.notes = p.notes;
        this.url = p.url;
    }

    public Password(){}

    public String getId() {
        return id;
    }

    public Password setId(String id) {
        this.id = id;
        return this;
    }

    public String getUserId() {
        return userId;
    }

    public Password setUserId(String userId) {
        this.userId = userId;
        return this;
    }

    public String getUsername() {
        return username;
    }

    public Password setUsername(String username) {
        this.username = username;
        return this;
    }

    public String getTitle() {
        return title;
    }

    public Password setTitle(String title) {
        this.title = title;
        return this;
    }

    public String getNotes() {
        return notes;
    }

    public Password setNotes(String notes) {
        this.notes = notes;
        return this;
    }

    public String getUrl() {
        return url;
    }

    public Password setUrl(String url) {
        this.url = url;
        return this;
    }

    public String getPassword() {
        return password;
    }

    public Password setPassword(String password) {
        this.password = password;
        return this;
    }


}
