using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<string, List<int>>();
            Console.WriteLine("enter number of students");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                var lst = new List<int>();
                for (int j = 0; j < 3; j++) {
                    lst.Add(int.Parse(Console.ReadLine()));
                }
                Console.WriteLine("enter the id ");
                string id = Console.ReadLine();
                d.Add(id, lst);
            }
            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key}:{string.Join(",", item.Value)}");
            }

        }
    }
}