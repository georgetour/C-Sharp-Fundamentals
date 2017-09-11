using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itirations
{
    class Program
    {
        static void Main(string[] args)
        {

            //An itiration is a loop that runs until a condition met
            //It's usually used so you can have the data of an array  or a lot of data

            #region for loop
            //The first value is like the start we set i, next we are saying if i<= 10 then i++
            for (var i = 0; i <= 10; i++) {


                //The % operator computes the remainder after dividing its first operand by its second
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }


            //Reverse order
            for (var i = 10; i >= 1; i--)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            #endregion





            #region foreach loop

            var name = "Bee";

            //A string is an array of characters. Length give as the total of the array and 
            //we are looping each index in it
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //The same more readable like for above
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            //Looping throu an array
            string[] fruits = new string[] { "banana","apple","melon"};

            foreach (var fruit in fruits)
            {

                Console.WriteLine(fruit);

            }

            #endregion




            #region while loop

            var k = 0;

            while (k<10) {

                k++;
                Console.WriteLine(k);

            }


            while (true) {

                Console.Write("Input your name");

                var input = Console.ReadLine();

                //Checking if string is not empty
                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo:" + input);
                    continue;//The loops continues and starts again from while
                }
                else
                {
                    break;
                }
                


            }

            #endregion



        }
    }
}
