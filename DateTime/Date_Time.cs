using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime1
{
    class Date_Time
    {
        static void Main(string[] args)
        {
            //DateTime
            var date = new DateTime(2021, 10, 10);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine($"Hour: {now.Hour}");
            Console.WriteLine($"Minute: {now.Minute}");

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());//shows date and time
            Console.WriteLine(now.ToString("yy-MM-dd"));
            Console.WriteLine(now.ToString("yy-MM-dd HH:mm"));//formatting date and time

            //TimeSpan
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine($"Duration: {duration}");

            //Properties
            Console.WriteLine($"Minutes: {timeSpan.Minutes}");
            Console.WriteLine($"Total Minutes: {timeSpan.TotalMinutes}");

            //Add
            Console.WriteLine($"Add Example: {timeSpan.Add(TimeSpan.FromMinutes(8))}");
            Console.WriteLine($"Subtract Example: {timeSpan.Subtract(TimeSpan.FromMinutes(2))}");

            //ToString
            Console.WriteLine($"ToString: {timeSpan.ToString()}");

            //Parse
            Console.WriteLine($"Parse: {TimeSpan.Parse("01:02:03")}");
        }
    }
}
