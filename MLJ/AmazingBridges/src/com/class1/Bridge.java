package com.class1;

public class Bridge {
    private int id;
    private String name;
    private String built_in;
    private double length;
    private double width;
    private double height;
    private String country;
    private String city;

    public Bridge(int id, String name, String built_in, double length, double width, double height, String country, String city) {
        this.id = id;
        this.name = name;
        this.built_in = built_in;
        this.length = length;
        this.width = width;
        this.height = height;
        this.country = country;
        this.city = city;
    }

    public Bridge() {

    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getBuilt_in() {
        return built_in;
    }

    public void setBuilt_in(String built_in) {
        this.built_in = built_in;
    }

    public double getLength() {
        return length;
    }

    public void setLength(double length) {
        this.length = length;
    }

    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    public String getCountry() {
        return country;
    }

    public void setCountry(String country) {
        this.country = country;
    }

    public String getCity() {
        return city;
    }

    public void setCity(String city) {
        this.city = city;
    }
}
