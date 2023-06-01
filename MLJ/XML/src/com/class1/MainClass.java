package com.class1;


import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import java.io.File;
import java.sql.Connection;

public class MainClass {
    public static void main(String[] args) {
        FoodDAO foodDAO = new FoodDAO();

        try {

            File inputFile = new File("breakfast_menu.xml");
            DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
            Document doc = dBuilder.parse(inputFile);
            doc.getDocumentElement().normalize();

            System.out.println("Root Name " + doc.getDocumentElement().getNodeName());

            NodeList foods = doc.getElementsByTagName("food");
            for (int i = 0; i < foods.getLength(); i++) {

                Food newFood = new Food();

                Element food = (Element) foods.item(i);
                System.out.println("----Food----");
                //Get Name
                NodeList nameList = food.getElementsByTagName("name");
                if(nameList != null) {
                    String name = nameList.item(0).getTextContent();
                    System.out.println("\tName " + name);
                    newFood.setName(name);
                }

                NodeList priceList = food.getElementsByTagName("price");
                if(priceList != null) {
                    String price = priceList.item(0).getTextContent();
                    System.out.println("\tPrice " + price);
                    newFood.setPrice(Float.parseFloat(price.replace("$","") ));
                }

                NodeList descriptionList = food.getElementsByTagName("description");
                if(descriptionList != null) {
                    String description = descriptionList.item(0).getTextContent();
                    System.out.println("\tDescription " + description);
                    newFood.setDescription(description);
                }

                NodeList caloriesList = food.getElementsByTagName("calories");
                if(caloriesList != null) {
                    String calories = caloriesList.item(0).getTextContent();
                    System.out.println("\tCalories " + calories);
                    newFood.setCalories(Integer.parseInt(calories));
                }

                System.out.println("Inserting new Food...");
                foodDAO.addFood( newFood );
            }

        } catch(Exception e) {
            System.out.println(e.getMessage());
        }
    }
}
