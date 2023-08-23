using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public Employee() { }
        public Employee(int id, string name, string title,
                        string description, string address)
        {
            Id = id;
            Name = name;
            Title = title;
            Description = description;
            Address = address;
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();

            Console.Write("Enter title: ");
            Title = Console.ReadLine();

            Console.Write("Enter Description: ");
            Description = Console.ReadLine();

            Console.Write("Enter Address: ");
            Address = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Name = {0} Title = {1} Description {2} Address {3}",
                                Name, Title, Description, Address);
        }

        //properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

    }
}
