using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_and_Constants
{
    class Program
    {
        static void Main(string[] args)
        {

        //Cannot start with number

            //No White space

            //Cannot be a reserved keyword

            //Use meaningfull names

            //Declaring an integer
            int number = 5;


            //A constant is number that we don't want to be changed like Pi
            const double Pi = 3.14;


            #region Primitive Types(or predifned)

            //Integral numbers
            //byte 0 - 255 bytes in memory 1
            byte small = 2;


            //short -32768 to 32767 bytes in memory 2

            //int -2.1B to 2.1 bytes in memory 4
            int count = 10;

            //long -bytes in memory 8

            //Real Numbers
            //float   -bytes in memmory 4
            float totalPrice = 10.25f;

            //double  -bytes in memory 8

            //decimal -bytes in memory 16

            //char -unicode characters bytes in memory 2
            char character = 'A';

            //bool -bytes in memory 1 True/False
            bool isWorking = true;

            //When you have real numbers you need to add the suffix else the compiler will treat it differently

            float myNumber = 1.2f;

            decimal biggerNumber = 1.3m;


            //You can also declare a variable and let C# auto detect it 
            //var keyword isn't allowed as fields but only in local variables
            var price = 10.25f;

         #endregion


        }
    }
}

