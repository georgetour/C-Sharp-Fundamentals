using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_With_Text_Exercises
{
    class Exercise_2
    {
        
        
        //***************Requirements***************
        //2- Write a program and ask the user to enter a few numbers separated by a hyphen.
        //If the user simply presses Enter, without supplying an input, exit immediately; 
        //otherwise, check to see if there are duplicates.
        //If so, display "Duplicate" on the console.
        //


        public static void CheckDuplicates()
        {

            Console.WriteLine("Write a few numbers seperated by , and I ll check duplicates");

            var input = Console.ReadLine();
           
                if (String.IsNullOrEmpty(input))
                {
                    return;
                }

            var numbers = new List<int>();
            
            

            var outputDisplay = "";

            foreach (var number in input.Split(','))
                numbers.Add(Convert.ToInt32(number));


            var uniqueNumbers = new List<int>();

            foreach (var number in numbers)
            {

                if (!uniqueNumbers.Contains(number))
                {
                    uniqueNumbers.Add(number);
                    outputDisplay = "No duplicates found";
                }
                else
                {
                    outputDisplay = "Duplicates found";
                    break;
                }
            }
            Console.WriteLine(outputDisplay);

            

            


        }
    }
}
