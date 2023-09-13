using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            int resultSubtraction = Subtraction(5, 2);
            Console.WriteLine(resultSubtraction);
        }

        static int Subtraction(int value1, int value2)
        {
            return value1 - value2;
            int result = Sum(1, 2);
            Console.WriteLine(result);
        }

        public static int Sum(int value1, int value2)
        {
           return value1 + value2;
        }
    }
}
