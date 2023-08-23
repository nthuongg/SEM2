using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1Class06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerController customerController = new CustomerController();
            int choose = 0;
            try
            {
                do
                {
                    Console.WriteLine("==========MENU==========");
                    Console.WriteLine("1. Add new customer");
                    Console.WriteLine("2.");
                    choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("ADD NEW CUSTOMER");
                            Console.WriteLine("Enter Name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter City: ");
                            string city = Console.ReadLine();
                            Console.WriteLine("Enter Country: ");
                            string country = Console.ReadLine();
                            Console.WriteLine("Enter Phone: ");
                            string phone = Console.ReadLine();
                            Console.WriteLine("Enter Email: ");
                            string email = Console.ReadLine();

                            Customer customer = new Customer
                            {
                                Name = name,
                                City = city,
                                Country = country,
                                Phone = phone,
                                Email = email
                            };
                            customerController.AddNewCustomer(customer);
                            break;
                        
                        case 2:
                            customerController.GetAllCustomers();
                            break;
                    }
                } while (true);

            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
