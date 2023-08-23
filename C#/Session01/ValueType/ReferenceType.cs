using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    internal class ReferenceType
    {
        public int valueVal;
    }

    internal class TestReference
    {
        static void Main(string[] args)
        {
            ReferenceType refer = new ReferenceType();
            //refer.valueVal = 5;
            Test(refer);
            Console.WriteLine("The value of the variable is {0}", refer.valueVal);
        }
        static void Test(ReferenceType refer)
        {
            int temp = 5;
            refer.valueVal = temp * 2;
        }

    }
}
