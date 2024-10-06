using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            var firstHalf = numbers.Take(numbers.Length / 2).Reverse().ToArray();
            var secondtHalf = numbers.Skip(numbers.Length/2+1).Reverse().ToArray();
            firstHalf.CopyTo(numbers, 0);
            secondtHalf.CopyTo(numbers,numbers.Length/2+1 );
            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
