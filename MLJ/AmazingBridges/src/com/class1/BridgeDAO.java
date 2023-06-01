package com.class1;

import com.class1.util.DBUtil;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;

public class BridgeDAO {
    public boolean addBridge(Bridge bridge) throws Exception {
        try {
            Connection connection = DBUtil.getConnection();
            PreparedStatement preparedStatement
                    = connection.prepareStatement(
                            "INSERT INTO nhom1_bridges(id, name, built_in, length, width, height, country, city) VALUES (?,?,?,?,?,?,?,?)"
            );
            preparedStatement.setInt(1, bridge.getId());
            preparedStatement.setString(2, bridge.getName());
            preparedStatement.setString(3, bridge.getBuilt_in());
            preparedStatement.setDouble(4, bridge.getLength());
            preparedStatement.setDouble(5, bridge.getWidth());
            preparedStatement.setDouble(6, bridge.getHeight());
            preparedStatement.setString(7, bridge.getCountry());
            preparedStatement.setString(8, bridge.getCity());

            return (preparedStatement.executeUpdate() > 0);
        }catch (Exception e) {
            throw new Exception(e.getMessage());
        }
    }
}
