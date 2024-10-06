﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumToWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            string input = " one, 2,three,four,2";
            var inputitems = input.Replace(" ", "").Split(',');
            var sb = new StringBuilder();
            foreach (var item in inputitems)
            {
                if (item.Length <= 2)
                {
                    int number = int.Parse(item);
                    string text = numbers[number - 1];
                    sb.Append($"{text};");


                }
                else
                {
                    sb.Append($"{item}");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}


