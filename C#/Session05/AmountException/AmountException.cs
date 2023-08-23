using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class AmountException : Exception
    {
        public string PersonName { get; }

        public AmountException(string personName, string message) : base(message)
        {
            PersonName = personName;
        }

    }

    public class Person
    {
        public virtual void CalculateSalary(int salary)
        {
            Console.WriteLine($"Base salary: {salary}");
        }
    }

    public class SeniorLecturer : Person
    {
        public override void CalculateSalary(int salary)
        {
            if (salary < 60000)
            {
                throw new AmountException("Senior Lecturer", "Salary cannot be less than 60,000");
            }

            Console.WriteLine($"Senior Lecturer salary: {salary}");
        }
    }

    public class Employee
    {
        public void CalculateBonus(int bonus)
        {
            if (bonus > 10000)
            {
                throw new AmountException("Employee", "Bonus cannot be more than 10,000");
            }

            Console.WriteLine($"Bonus: {bonus}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // Creating objects
                Person person = new Person();
                SeniorLecturer seniorLecturer = new SeniorLecturer();
                Employee employee = new Employee();

                // Demonstrate polymorphism
                person.CalculateSalary(50000);
                seniorLecturer.CalculateSalary(70000);

                // Demonstrate custom exception
                employee.CalculateBonus(15000);
            }
            catch (AmountException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Person Name: {ex.PersonName}");
            }
        }
    }
}
