using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonTypes
{
    internal class AnonTypes
    {
        //static void Main(string[] args)
        //{
        //    var p1 = new { Name = "A", Price = 3 };
        //    Console.WriteLine("Name = {0}\nPrice = {1}",
        //                      p1.Name.ToLower(), p1.Price);
        //}


        static void Main(string[] args)
        {

            Console.Write("Enter number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            //
            for (int i = number; i < 10; i++)
            {
                double test = 1 / i;
                Calc(test);
                Console.WriteLine("Test = " + test);
            }



            Console.WriteLine("End");

        }

        private static double Calc(double num)
        {
            Console.WriteLine(num);
            return num * num;
        }
    }

    
}
