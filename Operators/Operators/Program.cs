using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Operators

            //Operators + - * / %

            //Increment operator ++ same as a = a + 1 
            //Decrement operator --  same as b = b - 1

            //Postfix operator 

            int postFix = 1;
            int increased = postFix++;


            //Prefix
            int preFix = 1;
            int before = ++preFix;
            //Both Numbers will be 2

            //Comparison Operators Equal == , Not equal != , Greater than > , Greater than or equal to >= , LEss than < , Less than or equal to <=

            //Assignment Operators assignment = , addition assignment += , subtraction assignment -= , multiplication assignment *= , division assignment /=

            //Logical operators and && , or || , Not ! 

            var ab = 1;
            var ac = 2;
            var ad = 3;

            Console.WriteLine(ab < ac); //Returns true
            Console.WriteLine(ad > ac && ad > ab); //Returns true




            #endregion


        }
    }
}
