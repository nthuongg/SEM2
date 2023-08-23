using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.Id + ", ");
            stringBuilder.Append(this.Name + ", ");
            stringBuilder.Append(this.Email);

            return stringBuilder.ToString();
            //return this.Id + ", " + this.Name + ", " + this.Email;
        }

        // Id int
        // Name > length >=5
        // Email @

        public void Input()
        {
            try
            {
                Console.Write("Enter Id: ");
                this.Id = Convert.ToInt32(Console.ReadLine());

                if (this.Id < 0)
                {
                    throw new PersonInputException("Error input Id of Person");
                }

                Console.Write("Name: ");
                this.Name = Console.ReadLine();

                if (Name.Length < 5)
                {
                    throw new Exception("Name length must be > 5 characters");
                }

                Console.Write("Email: ");
                this.Email = Console.ReadLine();

                if (Email.IndexOf("@") < 0)
                {
                    throw new Exception("Email must have @");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }

    }

    internal class PersonInputException : Exception
    {
        public PersonInputException() { }

        public PersonInputException(string message)
            : base("PersonInputException " + message)
        {

        }

        public PersonInputException(string message, Exception innerException)
        : base(message, innerException)
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //FileStream file = File.OpenRead("newfile.txt");
                Person person = new Person();
                person.Input();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("FileNotFoundException");
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("IOException");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception");
                Console.WriteLine(e.Message);
            }

        }
    }
}
