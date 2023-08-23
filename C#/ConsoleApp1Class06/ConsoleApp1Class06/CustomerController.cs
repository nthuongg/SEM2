using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Class06
{
    internal class CustomerController
    {
        string CONNECTION = "Data Source=DESKTOP-19DCDDQ\\SQLEXPRESS;Initial Catalog=AZBank;User ID=sa;Password=123456789";
        public static void ReadData(string str)
        {
            var queryString = "SELECT * FROM Customer";

            //tao ket noi
            using (var connection = new SqlConnection(str))
            {
                var command = new SqlCommand(queryString, connection);
                //mo ket noi de co the thao tac voi du lieu trong bang
                connection.Open();
                // doc du lieu tu bang va in ra man hinh
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]}, {reader[1]}");
                    }
                }

                connection.Close();
            }
        }

        public void AddNewCustomer(Customer customer)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(CONNECTION);
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO Customer (NAME, CITY, COUNTRY, PHONE, EMAIL) VALUES (@name, @city, @country, @phone, @email)";
                sqlCommand.Parameters.AddWithValue("@name", customer.Name);
                sqlCommand.Parameters.AddWithValue("@city", customer.City);
                sqlCommand.Parameters.AddWithValue("@country", customer.Country);
                sqlCommand.Parameters.AddWithValue("@phone", customer.Phone);
                sqlCommand.Parameters.AddWithValue("@email", customer.Email);

                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("Add customer successful");
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void GetAllCustomers()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(CONNECTION);
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT NAME, CITY, COUNTRY, PHONE, EMAIL FROM Customer";
                SqlDataReader data = sqlCommand.ExecuteReader();

                while (data.Read())
                {
                    Console.WriteLine("{0} {1} {2} {3} {4}",
                        data.GetString(0),
                        data.GetString(1),
                        data.GetString(2),
                        data.GetString(3),
                        data.GetString(4)
                        );
                }

                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void UpdateCustomer()
        {

        }
    }


}
