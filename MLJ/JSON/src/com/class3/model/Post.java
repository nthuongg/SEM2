package com.class3.model;

public class Post {

    int id;
    int userId;
    String title;
    String body;

    public int getUserId() {
        return userId;
    }

    public void setUserId(int userId) {
        this.userId = userId;
    }

    public int getId() {
        return id;
    }

    public Post(int id, int userId, String title, String body) {

        this.id = id;
        this.userId = userId;
        this.title = title;
        this.body = body;
    }

    public void setId(int i) {
        this.id = i;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getBody() {
        return body;
    }

    public void setBody(String body) {
        this.body = body;
    }
}
