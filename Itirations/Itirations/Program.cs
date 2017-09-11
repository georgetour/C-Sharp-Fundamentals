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
            //It's usually used so you can have the data of array like 

            //The first value is like the start we set i, next we are saying if i<= 10 then i++
            for (var i = 0; i <= 10; i++) {


                //The % operator computes the remainder after dividing its first operand by its second
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }



            for (var i = 10; i >= 1; i--)
            {


                //The % operator computes the remainder after dividing its first operand by its second
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
