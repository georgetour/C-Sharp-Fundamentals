using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Class
{
    class Program
    {
        static void Main(string[] args)
        {


            //The Random Class exists in .net framework so we can generate random numbers
            var random = new Random();

            const int passwordLength = 10;

            var buffer = new char[passwordLength];


            for (var i = 0; i < passwordLength; i++)
            {
                
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
                
                
                //Generating random  alphabet character
                Console.WriteLine((char)('a' + random.Next(0,26))); 

                Console.WriteLine(password);


            var dice = random.Next(1, 20);
            Console.WriteLine("You rolled a " + dice);
           
            
            //ASCII code
            //Console.WriteLine((int)'a'); //Returns 97 which is his ascii code



        }
    }
}
