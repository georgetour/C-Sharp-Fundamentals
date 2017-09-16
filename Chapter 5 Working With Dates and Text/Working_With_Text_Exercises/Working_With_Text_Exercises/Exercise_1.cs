using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_With_Text_Exercises
{
    class Exercise_1
    {
        //************Requirements*********
        //Write a program and ask the user to enter a few numbers separated by a hyphen.
        //Work out if the numbers are consecutive. For example, 
        //if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: 
        //"Consecutive"; otherwise, display "Not Consecutive".

        public static void Consecutive()
        {

            Console.WriteLine("Write numbers separated with -");
            var input = Console.ReadLine();

            var numbers = new List<int>();

            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var check = true;

            for (int i = 0; i < numbers.Count; i++)
            {
                    if(numbers[i] != numbers[i - 1] + 1)
                    {
                        check = false;
                        break;
                    }       
                
               
            }

            
            var message = check ? "Consecutive" : "Not Consecutive";

            Console.WriteLine(message);



        }



    }
}
