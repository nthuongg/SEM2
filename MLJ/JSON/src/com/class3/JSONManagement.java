package com.class3;
import com.class3.controller.PostController;
import com.class3.model.Post;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Map;

public class JSONManagement {

    PostController postController = new PostController();

    public void readJSONFromApijsonplaceholder() throws Exception {
        try {
            String apiURL = "https://jsonplaceholder.typicode.com/posts";
            URL url = new URL(apiURL);

            HttpURLConnection conn = (HttpURLConnection) url.openConnection();
            conn.setRequestMethod("GET");

            BufferedReader reader = new BufferedReader(
                    new InputStreamReader(conn.getInputStream()));

            StringBuilder response = new StringBuilder();
            String line;
            while ((line = reader.readLine()) != null) {
                response.append(line);
            }
            reader.close();


            org.json.JSONArray jsonArray = new org.json.JSONArray(response.toString());
            for (int i = 0; i < jsonArray.length(); i++) {
                org.json.JSONObject post
                        = (org.json.JSONObject) jsonArray.get(i);

                System.out.println();
                System.out.println();
                System.out.println();
                System.out.println();

                Post newPost = new Post(
                        Integer.parseInt(post.get("id").toString()),
                        Integer.parseInt(post.get("userId").toString()),
                        post.get("title").toString(),
                        post.get("body").toString()
                );

                //insert into DB
                System.out.println("Inserting.......");
                postController.insertNewPost(newPost);
            }

        } catch (Exception e) {
            e.printStackTrace();
            System.out.println(e.getMessage());
        }
    }
    public void readJSONFromAPI() throws Exception {
        try {
            String apiUrl = "https://jsonplaceholder.typicode.com/posts";
            URL url = new URL(apiUrl);

            // Create connection
            HttpURLConnection conn = (HttpURLConnection) url.openConnection();
            conn.setRequestMethod("GET");

            // Read response
            BufferedReader reader = new BufferedReader(
                    new InputStreamReader(conn.getInputStream()));
            StringBuilder response = new StringBuilder();
            String line;
            while ((line = reader.readLine()) != null) {
                response.append(line);
            }
            reader.close();

            System.out.println(response.toString());

            org.json.JSONArray jsonArray = new org.json.JSONArray(response.toString());
            for (int i = 0; i < jsonArray.length(); i++) {
                org.json.JSONObject typicode
                        = (org.json.JSONObject) jsonArray.get(i);
                int userId = Integer.parseInt(typicode.get("userId").toString());
                int id = Integer.parseInt(typicode.get("id").toString());
                String title = typicode.get("title").toString();
                String body = typicode.get("body").toString();

                System.out.println("\n" + userId + "\n" + id + "\n" + title + "\n"+ body);

            }

            conn.disconnect();

        }catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
    public void readJSONPerson() throws Exception {
        try {
            JSONParser jsonParser =new JSONParser();
            Object obj = jsonParser.parse(new FileReader("person.json"));

            JSONObject jsonObject = (JSONObject) obj;
            Person person = new Person();

            int id = Integer.parseInt(jsonObject.get("id").toString());
            String firstName = jsonObject.get("firstName").toString();
            String lastName = jsonObject.get("lastName").toString();
            String email = jsonObject.get("email").toString();
            String department = jsonObject.get("department").toString();
            String position = jsonObject.get("position").toString();
            int salary = Integer.parseInt(jsonObject.get("salary").toString());
            String hireDate = jsonObject.get("hireDate").toString();
            String active = jsonObject.get("active").toString();

            person.setId(id);
            person.setFirstName(firstName);
            person.setLastName(lastName);
            person.setEmail(email);
            person.setDepartment(department);
            person.setPosition(position);
            person.setSalary(salary);
            person.setHireDate(hireDate);
            person.setActive(active);

            Map mapAddress = (Map) jsonObject.get("address");
            String streetAddress = mapAddress.get("streetAddress").toString();
            String city = mapAddress.get("city").toString();
            String state = mapAddress.get("state").toString();
            String postalCode = mapAddress.get("postalCode").toString();

            Address address = new Address(streetAddress, city,state,postalCode);
            person.setAddress(address);
            System.out.println(person);


        }catch (Exception e) {
            e.printStackTrace();
            throw new Exception(e.getMessage());
        }
    }
}
