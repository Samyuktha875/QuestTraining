using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OccurenceOfWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = " this is a really long long text";
            string[] words = text.Split(' ');
            foreach(var word in words)
            {
                int count = 0;
                foreach(var item in words)
                {
                    if (word == item)
                    {
                        count++;
                        
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
