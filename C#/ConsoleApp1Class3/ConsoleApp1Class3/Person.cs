using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Class3
{
    internal abstract class Person
    {
        private int Count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public Person() 
        {
            this.Id = ++Count;
        }


        public abstract double GetBonus();
        public double GetTotalSalary()
        {
            return GetBonus() + Salary;
        }
        public abstract void Input();
        public abstract void Display();
    }

    internal class Employee : Person 
    {
        //Default Constructor
        public Employee() { }

        //Parameter constructor
        public Employee(string name, string email, string address) 
        {
            this.Name = name;
            this.Email = email;
            this.Address = address;
        }

        //Copy constructor
        public Employee(Employee emp)
        {
            this.Name = emp.Name;
            this.Email = emp.Email;
            this.Address = emp.Address;
        }

        public override double GetBonus()
        {
            return Salary * 2; 
        }
        public override void Display()
        {
            Console.WriteLine("This is Employee");
            Console.WriteLine("Id = {0}, Name = {1}, Email = {2}, Address= {3}, Salary = {4}",
                this.Id, this.Name, this.Email, this.Address, this.Salary);
        }

        public override void Input()
        {
            Console.Write("Enter name: ");
            this.Name = Console.ReadLine();

            Console.Write("Enter email: ");
            this.Email = Console.ReadLine();

            Console.Write("Enter address: ");
            this.Address = Console.ReadLine();

            Console.WriteLine("Enter salary: ");
            this.Salary = double.Parse(Console.ReadLine());
        }
    }

    internal class Manager : Person
    {
        public string Role { get; set; }
        public Manager() { }

        public override double GetBonus()
        {
            return Salary * 3;
        }
        public override void Display()
        {
            Console.WriteLine("Thia is Manager");
            Console.WriteLine("Id = {0}, Name = {1}, Email = {2}, Address= {3}, Role = {4}",
                this.Id, this.Name, this.Email, this.Address, this.Role);
        }
        public override void Input()
        {
            Console.WriteLine("Enter name: ");
            this.Name = Console.ReadLine();

            Console.WriteLine("Enter email: ");
            this.Email = Console.ReadLine();

            Console.WriteLine("Enter address: ");
            this.Address = Console.ReadLine();

            Console.WriteLine("Enter role: ");
            this.Role = Console.ReadLine();

            Console.WriteLine("Enter salary: ");
            this.Salary = double.Parse(Console.ReadLine());
        }
    }
}
