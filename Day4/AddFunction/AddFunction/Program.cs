using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddFunction
{
    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {

            int number1 = 50;
            int number2 = 50;

            int result = Add(number1, number2);

            Console.WriteLine("The sum is: " + result);
        }
    }
}
