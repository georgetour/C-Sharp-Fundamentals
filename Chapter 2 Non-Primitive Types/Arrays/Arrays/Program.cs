using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Arrays are non-primitive types that hold a collection of variables of the same type
            //They have fixed size and they are 0 based indexed
            //If we don't have an index it will return 0 for int etc,string will return empty  , bool will return false

            int[] score = new int[2];
            score[0] = 92;
            score[1] = 58;


            string[] names = new string[3];

            names[0] = "John";
            names[1] = "Cookie";
            names[2] = "Choco";


            //Or string[] names = new string[3] {"John" , "Cookie", "Choco"}; This is called object initilazation syntax
            //or var names = new string[3];

            Console.WriteLine(names[2]); //Returns Choco




        }
    }
}
