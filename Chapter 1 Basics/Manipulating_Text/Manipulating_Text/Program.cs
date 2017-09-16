using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Text
{
    class Program
    {
        static void Main(string[] args)
        {

            var fullName = "George Tourtsinakis ";

            //Trim removes empty space at begin or end
            Console.WriteLine("Trim: '{0}'",fullName.Trim());

            //Since strngs are immutable they don't modify the original string 
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());//You will see it has empty spaces



            //Getting from our fullName first name and last name
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First name : " + firstName);
            Console.WriteLine("Last name : " + lastName);


            //Split returns a string array
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            //Replace
            var newName = fullName.Replace("George", "Bee");
            Console.WriteLine(newName);

            //Validation
            
            if (String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid");
            }

            if (String.IsNullOrEmpty(" "))
            {
                Console.WriteLine("This will not show anything ");
            }


            //Wrong
            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid");
            }

            //Correct new version
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var input = "25";
            var age= Convert.ToByte(input);


            float price = 29.95f;

            //This fixes encoding
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //Outputting float to string with currency
            Console.WriteLine(price.ToString("C"));

        }
    }
}
