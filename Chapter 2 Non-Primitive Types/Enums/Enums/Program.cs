using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {

        //An enum is a set of value pairs(contants). Instead of declaring multiple constants declare an enum
        //It's declared in high level in namespace since it's new type

        //if you want to create an application for different shipping methods for a company
        //You could
        //const int regularAirMail = 1;
        //const int registerAirMail = 2;
        //const int Express= 3;


        //With enum
        public enum ShippingMethod
        {
            regularAirMail = 1,
            registerAirMail = 2,
            Express = 3

        }


        static void Main(string[] args)
        {

            //Casting the enum
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);//Returns the shipping method with 3 Express

            //Casting the SmethodId and getting our third shipping method
            var methodId = 1;
            Console.WriteLine((ShippingMethod)methodId);


            //Converting ToString
            Console.WriteLine(method.ToString());



            //Parsing means getting string and converting to a diffrent type
            var methodName = "Express";

            //Convert string to typeof ShippingMethod but it returns an object so we cast it as ShippingMethod
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine(shippingMethod);









        }
    }
}
