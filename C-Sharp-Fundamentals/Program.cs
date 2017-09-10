using System;

using C_Sharp_Fundamentals.Math;

namespace C_Sharp_Fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {

           
          

            #region Format String

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);


            #endregion





           


            //To call classes from a namespace you must write using C_Sharp_Fundamentals.Math; like here in Program.cs class

            //We must have one class per file
            //Creating an object 

            Client client = new Client();
            client.name = "Bee";
            client.age = 30;


            //Access class members
            client.ClientsDetails();

            //Static methods or fields can't be accessed from obejcts but directly
            //We use static when we want to present a content that only one instanse of that should exist in memory
            var result = Calculator.AddNumber(1, 2);
            Console.WriteLine(result);


            //Get array from MyArray class
            MyArray myArray = new MyArray();
            string[] jars = myArray.myarray();

            Console.WriteLine(jars[2]); //Will return chocolate


            //Strings
            MyString myFirstString= new MyString();
            myFirstString.myDetails();

            myFirstString.myDetails();



            //Enum shipping method price
            
            Console.WriteLine(ShippingMethod.registerAirMail);

            //Casting the enum
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);//Returns the shipping method with 3 Express

            //Parsing means getting string and converting to a diffrent type
            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);


        }
    }
}
