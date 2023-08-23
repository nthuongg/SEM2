package com.class1;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import java.io.File;

public class Main {
    public static void main(String[] args) {
        try {
            File inputFile = new File("breakfast_menu.xml");
            DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
            Document doc = dBuilder.parse(inputFile);
            doc.getDocumentElement().normalize();

            System.out.println("Root Name " + doc.getDocumentElement().getNodeName());

            NodeList foods = doc.getElementsByTagName("food");
            for (int i = 0; i < foods.getLength(); i++) {
                Element food = (Element) foods.item(i);
                System.out.println("------Food-------");

                //Get Name
                NodeList nameList = food.getElementsByTagName("name");
                if(nameList != null) {
                    String name = nameList.item(0).getTextContent();
                    System.out.println("\tName " + name);
                }

                NodeList priceList = food.getElementsByTagName("price");
                if(priceList != null) {
                    String price = priceList.item(0).getTextContent();
                    System.out.println("\tPrice " + price);
                }

                NodeList descriptionList = food.getElementsByTagName("description");
                if(descriptionList != null) {
                    String description = descriptionList.item(0).getTextContent();
                    System.out.println("\tDescription " + description);
                }

                NodeList caloriesList = food.getElementsByTagName("calories");
                if(caloriesList != null) {
                    String calories = caloriesList.item(0).getTextContent();
                    System.out.println("\tCalories " + calories);
                }
            }
        }catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}