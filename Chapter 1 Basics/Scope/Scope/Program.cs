using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {

            //Scope is where a variable or constant is accessible 

            byte a = 1; //b and c are not available here

            {
                byte b = 2; //a is available here

                {

                    byte c = 3; //a nd b are available here

                }

            }


        }
    }
}
