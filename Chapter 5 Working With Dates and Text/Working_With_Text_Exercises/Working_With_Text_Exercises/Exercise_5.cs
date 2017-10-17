using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_With_Text_Exercises
{
    class Exercise_5
    {
        /*Write a program and ask the user to enter an English word. 
         * Count the number of vowels (a, e, o, u, i) in the word. 
         * So, if the user enters "inadequate", 
         * the program should display 6 on the console.
         */

        public static void  CountVowels() {

            Console.WriteLine("Write an english word");
            var input = Console.ReadLine();

            char[] array = input.ToCharArray();

            var counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                
                switch (array[i])
                {
                    case 'a':
                        counter++;
                        break;
                    case 'e':
                        counter++;
                        break;
                    case 'o':
                        counter++;
                        break;
                    case 'u':
                        counter++;
                        break;
                    case 'i':
                        counter++;
                        break;

                }
            }

            Console.WriteLine(String.Format("Your word contains {0} vowels",counter));

        }

        

    }
}
