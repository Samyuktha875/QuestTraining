using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringbulider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = { "name1", "name2", "name3" };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++) {
                sb.AppendLine(s[i].Trim() + " " + (i + 1)
                    "age is");
            }
        }
    }
}
