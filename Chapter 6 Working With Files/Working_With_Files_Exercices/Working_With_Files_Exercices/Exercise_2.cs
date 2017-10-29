using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Working_With_Files_Exercices
{
    class Exercise_2
    {
        //Write a program that reads a text file and displays the longest word in the file

        public static void LongestWordInFile()
        {
            var path = @"e:/lorem_ipsum.txt";

            var content = File.ReadAllText(path);

            var words = content.Split(' ');
            string longestWord = words[0];

            //It's a trick that passes the longest word to longestWord after comparing it with all words length
            for (int i = 0; i < words.Length; i++)
            {

                if (longestWord.Length < words[i].Length)
                {
                    longestWord = words[i];
                }
            }

            Console.WriteLine("Longest word is " + longestWord);
            
            

        }


    }
}
