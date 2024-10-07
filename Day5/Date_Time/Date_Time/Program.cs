using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // local time
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            //UTC
            DateTime dtu = DateTime.UtcNow;
            Console.WriteLine(dtu);

            Console.WriteLine($" Day:{dt.Day}");
            Console.WriteLine($" Day:{dt.Month}");
            Console.WriteLine($" Day:{dt.Year}");

            Console.WriteLine($" Day:{dt.Hour}");
            Console.WriteLine($" Day:{dt.Minute}");
            Console.WriteLine($" Day:{dt.Second}");
            Console.WriteLine($" Day:{dt.Millisecond}");


            //formating output

            Console.WriteLine("--------------------------");
            Console.WriteLine($"standard output: {dt}");
            Console.WriteLine(dt.ToString("dd-MM-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM-dd-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM-dd-yyyy"));
            Console.WriteLine(dt.ToString("hh:mm:ss"));

            //addiing days
            var tenDaysFromNow = dt.AddDays(10);
            Console.WriteLine(tenDaysFromNow);

            var twentyDaysFromNow = dt.AddDays(20);
            Console.WriteLine(twentyDaysFromNow);

            // construccting date and time
            var myDt = new DateTime(2024, 10, 7, 12, 50, 59);
            Console.WriteLine($"My date and time:{ myDt}");


        }
    }
}
