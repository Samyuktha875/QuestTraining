using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveEvenNum_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter number {i+1};");
                lst.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] % 2 == 0)
                {
                    lst.RemoveAt(i);
                }

            }
        }
    }
}
