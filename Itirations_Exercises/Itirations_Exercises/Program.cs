using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itirations_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //Run here to see the method you want to check how it works. For example
            biggerNumber();

        }

        public static void divisible()
        {
            //Write a program to count how many numbers between 
            //1 and 100 are divisible by 3 with no remainder.
            //Display the count on the console.


            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine("The numbers that can be divided by 3 are {0}", count);

        }

        //Write a program and continuously ask the user to enter a number or "ok" to exit. 
        //Calculate the sum of all the previously entered numbers 
        //and display it on the console.
        public static void unlimitedCount() {
            
            var sum = 0;

            while (true)
            {

                Console.WriteLine("Enter a number or write ok to exit");
                var input = Console.ReadLine();

                if (input == "ok")
                {
                    break;
                }
                else
                {
                    sum += Convert.ToInt32(input);
                }
                Console.WriteLine("Sum of numbers is  {0}", sum);
            }
        }



        //    Write a program which takes a single argument from the console, computes the factorial and prints the
        ///// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        ///// and display it as 5! = 120.
        public static void factorial() {

            Console.WriteLine("Write a number and I will give you the factorial");
            var inputNumber = Convert.ToInt32(Console.ReadLine());
            int result = inputNumber;

            for (int i = 1; i < inputNumber; i++)
            {
                result = result * i;

            }

            Console.WriteLine(result);

        }





        //Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the number.
        //If the user guesses the number, display “You won"; otherwise, display “You lost". 
        //(To make sure the program is behaving correctly, you can display the secret number on the console first.)
        public static void guessNumber() {

            var random = new Random();

            var randomNumber = random.Next(1, 10);

            Console.WriteLine(randomNumber);
            Console.WriteLine("Guess a number");

            var totalTries = 0;

            while (totalTries <= 4)
            {
                var pickedNumber = Convert.ToInt32(Console.ReadLine());
                if (randomNumber == pickedNumber)
                {
                    
                    totalTries = 4;
                    Console.WriteLine("Correct number");
                    break;
                }
                else if (randomNumber != pickedNumber)
                {

                    totalTries++;
                    Console.WriteLine("Wrong number");
                    continue;
                }
            }
        }


        /// <summary>
        /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
        /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
        /// display 8 on the console.
        /// </summary>
        public static void biggerNumber()
        {




            Console.WriteLine("Enter comma seperated numbers");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            //Just declare the fake max that will change later according to biggest number
            var max = 0;

            foreach (var item in numbers)
            {

                var number = Convert.ToInt32(item);

                if (number > max) {

                    max = number;
                    
                }
            }

            Console.WriteLine("the biggest number is " + max);

            



        }





    }//End Class
}
