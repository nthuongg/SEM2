package com.class3;

public class Main {
    public static void main(String[] args) {
        try {
            JSONManagement jsonManagement = new JSONManagement();
            jsonManagement.readJSONFromApijsonplaceholder();
//            jsonManagement.readJSONPerson();
//            jsonManagement.readJSONFromAPI();
        }catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}