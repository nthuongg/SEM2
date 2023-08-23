package com.class1;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import java.io.File;


public class Main {
    public static void main(String[] args) {
        BridgeDAO bridgeDAO =new BridgeDAO();
        int id = 55;
        try {

            File inputFile = new File("bridge.xml");
            DocumentBuilderFactory dbFactory = DocumentBuilderFactory.newInstance();
            DocumentBuilder dBuilder = dbFactory.newDocumentBuilder();
            Document doc = dBuilder.parse(inputFile);
            doc.getDocumentElement().normalize();

            System.out.println("Root Name " + doc.getDocumentElement().getNodeName());

            NodeList bridges = doc.getElementsByTagName("bridge");
            for (int i = 0; i < bridges.getLength(); i++) {

                Bridge newBridge = new Bridge();

                Element bridge = (Element) bridges.item(i);
                System.out.println("----Bridge----");
                //Get Name
                NodeList nameList = bridge.getElementsByTagName("name");
                if (nameList != null) {
                    String name = nameList.item(0).getTextContent();
                    System.out.println("\tName " + name);
                    newBridge.setName(name);
                }

                NodeList built_inList = bridge.getElementsByTagName("built_in");
                if (built_inList != null) {
                    String built_in = built_inList.item(0).getTextContent();
                    System.out.println("\tBuilt_in " + built_in);
                    newBridge.setBuilt_in(built_in);
                }

                NodeList lengthList = bridge.getElementsByTagName("length");
                if (lengthList != null) {
                    String length = lengthList.item(0).getTextContent();
                    System.out.println("\tLength " + length);
                    newBridge.setLength(Double.parseDouble(length));
                }

                NodeList widthList = bridge.getElementsByTagName("width");
                if (widthList != null) {
                    String width = widthList.item(0).getTextContent();
                    System.out.println("\tWidth " + width);
                    newBridge.setWidth(Double.parseDouble(width));
                }

                NodeList heightList = bridge.getElementsByTagName("height");
                if (heightList != null) {
                    String height = heightList.item(0).getTextContent();
                    System.out.println("\tHeight " + height);
                    newBridge.setHeight(Double.parseDouble(height));
                }

                NodeList countryList = bridge.getElementsByTagName("country");
                if(countryList != null) {
                    String country = countryList.item(0).getTextContent();
                    System.out.println("\tCountry " + country);
                    newBridge.setCountry(country);
                }

                NodeList cityList = bridge.getElementsByTagName("city");
                if(cityList != null) {
                    String city = cityList.item(0).getTextContent();
                    System.out.println("\tCity " + city);
                    newBridge.setCity(city);
                }

                newBridge.setId(id++);
                System.out.println("Inserting new Bridge...");
                bridgeDAO.addBridge(newBridge);

            }

        }catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}