using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args) { 
            string text = "malayalam";
        var reverse = string.Concat(text.Reverse());
            if (text == reverse)
            {
                Console.WriteLine("same");
            }
        
        
        }
    }
}
