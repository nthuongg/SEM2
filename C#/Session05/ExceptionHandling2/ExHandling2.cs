using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    public class InvalidInput : ApplicationException
    {
        public InvalidInput() : base("Enter a number greater than Zero") { }
    }
    internal class TestException
    {
        public static void Main()
        {
            int intCnt;
            int intNum = 0;
            Console.WriteLine("Enter a number : ");
            try
            {
                intNum = Convert.ToInt32(Console.ReadLine());
                if (intNum <= 0)
                {
                    throw new InvalidInput();
                }
            }
            catch (InvalidInput objInvalidInput)
            {
                Console.WriteLine(objInvalidInput.Message);
            }
            catch (System.FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }
            finally
            {
                if (intNum > 0)
                {
                    for (intCnt = 0; intCnt <= 10; intCnt++)
                        Console.WriteLine(intCnt * intNum);
                }
            }
        }
    }
}
