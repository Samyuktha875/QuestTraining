using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            Console.WriteLine("Enter the word to be replaced:");
            string oldWord = Console.ReadLine();

            Console.WriteLine("Enter the word to replace it with:");
            string newWord = Console.ReadLine();

            string newSentence = sentence.Replace(oldWord, newWord);

            Console.WriteLine("The new sentence is: " + newSentence);
        }
    }
}

   
      
