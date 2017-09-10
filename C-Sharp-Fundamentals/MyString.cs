using System;

namespace C_Sharp_Fundamentals
{
    public class MyString
    {
        
        public void myDetails() {
            //A string is a sequence of characters and we have it inside double quotes

            string firstName = "George";
            string lastName = "Bee";

            // To concatinate strings use + 
            string details = "Hello my first Name is " + firstName + "and my last " + lastName ;


            #region String Format
            //String format the first parameter defines the template of the string which have placeholders and are zero indexed 
            //the other parameters what we will have in them
            string formatDetails = string.Format("First name {0},Last name {1}", firstName, lastName);

            Console.WriteLine(formatDetails);
            #endregion


            #region String join
            //Using string join which combines elements and uses the first parameter as the seperator
            var numbers = new int[3];
            string total = string.Join(",", numbers);

            #endregion

            #region String Elements
            //String elements
            string name = "Bee";
            char firstChar = name[0]; //Returns f

            #endregion

            //Strings are immutable which means when are declared can't be changed

            #region Escape Characters
            //Escape characters
            // \n new line
            // \t Tab
            // \\ Backslash
            // \' Single Quotation Mark
            // \" Double Quotation Mark


            #endregion



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

        }
        

    }
}
