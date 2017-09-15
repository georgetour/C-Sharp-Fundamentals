using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
   


    class Program
    {

        static void Main(string[] args)
        {


            #region If/else

            int hour = 10;

            if (hour > 0 && hour < 12) //The value of hour was 10 so this line of code was evaluated
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {

                Console.WriteLine("It's evening");

            }

            bool isGoldCustomer = true;

            //float price;

            //if (isGoldCustomer)
            //{
            //    price = 19.90f;

            //}
            //else
            //{

            //    price = 22f;
            //}

            //Conditional(ternary) oparator if isGoldCustomer 19.9 else 22
            float price = (isGoldCustomer) ? 19.90f : 22f;

            Console.WriteLine("Your price is " + price);

            #endregion



            #region Switch case

            var season = Season.Spring;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("We have autumn and it's a beautiful season");
                    break;

                //If season is spring or summer then we have a promotion
                case Season.Spring:
                case Season.Summer:
                    Console.WriteLine("We have a promotion");
                    break;

                case Season.Winter:
                    Console.WriteLine("It's winter we need to be warm");
                    break;
                default:
                    Console.WriteLine("Unknown season");
                    break;

            }



            #endregion


            //Write a program that asks for a number between 1 to 10
            Console.WriteLine("Write a number from 1 to 10");
            var checkNumber = Convert.ToInt32(Console.ReadLine());

            if (checkNumber > 1 && checkNumber <= 10)
                Console.WriteLine("Valid number");
            else
                Console.WriteLine("Not Valid number");



            /// <summary>
            /// Write a program which takes two numbers from the console and displays the maximum of the two.
            /// </summary>
            Console.WriteLine("Give first number ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give second number ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            //if firstNumber > secondNumber then highestNumber = firstNumber else highestNumber = secondNumber
            var highestNumber = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            Console.WriteLine("The bigger number is " + highestNumber);



            /// <summary>
            /// Write a program which takes image height and width. Then tell if the image is landscape or portrait
            /// </summary>

            Console.WriteLine("Give image width");
            var imageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give image height");
            var imageHeight = Convert.ToInt32(Console.ReadLine());

            


            var imageOrientation = imageHeight > imageWidth ? "Portrait": "Landscape";
            Console.WriteLine(imageOrientation);


            /// <summary>
            ///Your job is to write a program for a speed camera. For simplicity, 
            ///ignore the details such as camera, sensors, etc
            /// and focus purely on the logic. 
            ///Write a program that asks the user to enter the speed limit. 
            ///Once set, the program asks for the speed of a car. 
            ///If the user enters a value less than the speed limit, 
            ///program should display Ok on the console. If the value is above the speed limit, 
            ///the program should calculate the number of demerit points. 
            ///For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
            ///If the number of demerit points is above 12, the program should display License Suspended.
            /// </summary>


            Console.WriteLine("What's the speed limit?");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's the speed of the car?");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else {

                const int kmPerDemeritPoint = 5;
                //Total car speed minus speed we get the diffrence in km and then since 1 demerit point = 5 we divide the difference with 5
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);

            }
            




        }
    }
}
