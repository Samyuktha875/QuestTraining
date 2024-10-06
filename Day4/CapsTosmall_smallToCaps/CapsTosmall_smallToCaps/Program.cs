using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsTosmall_smallToCaps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "HellO WoRLD";

            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result[i] = char.ToLower(input[i]);
                }
                else
                {
                    result[i] = char.ToUpper(input[i]);
                }
            }

            Console.WriteLine(new string(result));
        }
    }
      
}


