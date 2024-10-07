using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var lst = new List<int>();
            //for (int i = 0; i < 5; i++)

            var data = new List<List<int>>();
            for (int i = 0; i < 2; i++)
            {
                var marks = new List<int>();
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"enter mark{j}:");
                    int mark = int.Parse(Console.ReadLine());
                    marks.Add(mark);
                }
                data.Add(marks);
            }
            Console.ReadKey();
        }
        // list declaration

        List<int> lst = new List<int>();

        //add single element
        lst.Add(10);
            
            //adding multiple elements
            var values = new int[] { 20, 30, 40 };
        lst.AddRange(values)

            //updating
            lst[0] = 100;

        //deleting 1st occurence
        lst.Remove(50);
            
            // Remove at specific index
            lst.RemoveAt(0);

            for(int i=0;i<lst.Count;i++){
            Console.Write(lst[i]+" ");
            }


    }
}
