using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_With_Text_Exercises
{
    class Exercise_3
    {

        /*
        Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
        A valid time should be between 00:00 and 23:59. If the time is valid, 
        display "Ok"; otherwise, display "Invalid Time". 
        If the user doesn't provide any values, consider it as invalid time. 
        */
        public static void CheckTime()
        {
            Console.WriteLine("Give a valid time ex 19:00");
            var input = Console.ReadLine();

            DateTime time = new DateTime();


            string format = "HH:mm";

            //We try to exact the input with the format, check the overloads
            if (DateTime.TryParseExact(input, format, new CultureInfo("en-us"), DateTimeStyles.None, out time))
                Console.WriteLine("Ok");
            else
            {
                Console.WriteLine("invalid");

            }


        }


    }
}
