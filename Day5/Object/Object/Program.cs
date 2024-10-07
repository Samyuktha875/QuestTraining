using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    internal class Program
    {
        static void DoThis(object a, object b)
        {
            if (a.GetType() == typeof(string))
            {

            }
        }
        static void Main(string[] args)
        {
            DoThis(1, 2);
            //DoThis("hello", "world");
            //string s= Console.ReadLine();

            string s = "hi";
            Type t= s.GetType();
            Console.WriteLine(t.Name);
        }
    }
}
