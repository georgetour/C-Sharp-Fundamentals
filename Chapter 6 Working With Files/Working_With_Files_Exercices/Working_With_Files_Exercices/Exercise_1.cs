using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Working_With_Files_Exercices
{
    class Exercise_1
    {

        //- Write a program that reads a text file and displays the number of words.

        public static void CountWordsInFile() {

            var path = @"e:/lorem_ipsum.txt";

            var content = File.ReadAllText(path);

            int count = content.Split(' ').Length;
           
            Console.WriteLine(count);


        }


    }
}
