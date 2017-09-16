using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            //A string is a sequence of characters example "Hello C#" and we have it inside double quotes

            string firstName = "George";
            string lastName = "Bee";

            //To concatinate string use + 
            string details = "Hello my first Name is " + firstName;



            #region String Format
            //String format the first parameter defines the template of the string which have placeholders and are zero indexed 
            //the other parameters what we will have in them
            string formatDetails = string.Format("First name {0},Last name {1}", firstName, lastName);

            Console.WriteLine(formatDetails);
            #endregion


            
            #region String join
            //Using join which combines elements and uses the first parameter as the seperator
            var numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            string total = string.Join(",", numbers);

            Console.WriteLine(total);


            #endregion


            //String elements
            string name = "Bee";
            char firstChar = name[0]; //Returns f

            //Strings are immutable which means when are declared can't be changed

            //Escape characters
            // \n new line
            // \t Tab
            // \\ Backslash
            // \' Single Quotation Mark
            // \" Double Quotation Mark


            #region  Verbatim strings

            //Verbatim strings are used so u don't have to use all that backslashes, line breaks etc

            //Bad
            string path = "c:\\projects\\project1\\main";

            //Verbatim string
            string correctPath = @"c:\projects\project1\main";

            string verbatim = @"Hi look in here
path1
path2";


            Console.WriteLine(verbatim + " " + correctPath);


            //Convert something to string
            //Premade method ToString

            int number = 5;
            string convertedNumber = number.ToString();


            #endregion


            #region Format String

            Console.WriteLine("{0} - {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} - {1}", float.MinValue, float.MaxValue);


            #endregion



        }
    }
}
