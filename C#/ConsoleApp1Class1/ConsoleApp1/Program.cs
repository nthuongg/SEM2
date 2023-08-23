using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void changeInt(int num)
        {
            num += 2;
        }

        static void changeIntRef(ref int num) // ---> * pointer
        {
            num += 3;
        }

        static void Main(string[] args)
        {
            int number = 10;
            changeInt(number);
            //changeIntRef(ref number);

            Console.WriteLine("Number = " + number);

            int []numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = i * i;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number {0} = {1}", i + 1, numbers[i] );
            }

            Employee employee = new Employee();
            employee.Input();
            employee.Display();

            //Console.WriteLine("Hello World");
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Hello " + name + ", you are " + age + " years old");
        }
    }
}
