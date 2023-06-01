package com.class1;

import java.sql.CallableStatement;
import java.sql.Connection;

public class FoodDAO {
    public boolean addFood(Food food) throws Exception {
        try {
            Connection connection = DBUtil.getConnection();
            CallableStatement callableStatement
                    = connection.prepareCall("{call sp_create_food(?, ?, ?, ?)}");
            callableStatement.setString(1, food.getName());
            callableStatement.setFloat(2, food.getPrice());
            callableStatement.setString(3, food.getDescription());
            callableStatement.setInt(4, food.getCalories());

            return ( callableStatement.executeUpdate() > 0);

        } catch (Exception e) {
            throw new Exception(e.getMessage());
        }
    }
}
