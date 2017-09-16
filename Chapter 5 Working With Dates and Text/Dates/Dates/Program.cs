using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {


            //Datetime 

            //You just work with Datetime object
            var dateTime = new DateTime(2017-9-11);

            var now= DateTime.Now;

            var today = DateTime.Today;


            Console.WriteLine("Now hour" +now.Hour);

            var tomorrow = now.AddDays(1);

            Console.WriteLine("Tomorrow: " +tomorrow);


            Console.WriteLine(now.ToLongDateString());

            Console.WriteLine(now.ToShortDateString());

            Console.WriteLine(now.ToLongTimeString());

            Console.WriteLine(now.ToShortTimeString());

            //It has some overloads
            Console.WriteLine(now.ToString("dd-MM-yyyy"));


            //Timespan
            //It reoresents a length oftime

            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);

            //More readable 

            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(3);
            var duration = end - start;
            Console.WriteLine("Duration " + duration);


            //Properties
            Console.WriteLine("Minutes:" + timeSpan.Minutes);

            //Converts total in minutes, in our timeSpan variable we have 1 hour 2 minutes 
            Console.WriteLine("Total Minutes:" + timeSpan.TotalMinutes);


            //Add minutes
            Console.WriteLine("Add example " + timeSpan.Add(TimeSpan.FromMinutes(8)));

            //Subtract
            Console.WriteLine("Subtract example " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));



            //ToString
            Console.WriteLine("Covnverted to string " + timeSpan.ToString());


            //Parse
            Console.WriteLine("Parse " + TimeSpan.Parse("01:02:15"));


            //DateTime and TimeSpan are immutable


        }
    }
}
