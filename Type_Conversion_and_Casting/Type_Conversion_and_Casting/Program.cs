using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion_and_Casting
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Type Conversion

            //Implicit Type Conversion
            byte b = 1;

            int i = b;

            int c = 1;

            float f = c;

            //Doing a cast in C# is telling the compiler to do an explicit conversion to 
            //convert the type of an object from one to another, 
            //and by explicit it means that you are aware that data may be truncated during the operation. 
            // For example : converting a decimal to a float

            //Explicit Type Conversion
            int myNumber = 1;

            byte smallerNumber = myNumber; //Won't compile error since byte is smaller that int



            float k = 1.0f;

            //Casting
            int z = (int)k;


            //IF we want to test something and don't let the application crash we use try and catch
            try
            {
                var myString = 1234;
                byte stringTobYTE = Convert.ToByte(myString);
                Console.WriteLine(myString);

            }
            catch (Exception)
            {

                Console.WriteLine("String couldn't be converteed to byte");

            }

            //Non-compatible types
            string s = "1";

            //int newString = (int)s; //Compile Error


            //Parse or Convert
            int fromString = Convert.ToInt32(s);

            int fromString2 = int.Parse(s);


            #endregion

        }
    }
}
