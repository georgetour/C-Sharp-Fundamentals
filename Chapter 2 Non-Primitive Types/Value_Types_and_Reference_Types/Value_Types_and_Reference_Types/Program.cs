using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types_and_Reference_Types
{

    public class Person {

        public int Age;

    }


    class Program

    {



        static void Main(string[] args)
        {
            //Value Types
            //Allocated on stack
            //Memory allocation Done automatically
            //Removed when out of scope

            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/value-types 

            //Reference Types
            //You need to allocate memory
            //Memory allocated on heap(temporary stored)
            //Garbage Collection by CLR(automatically the CLR looks for objects that isn't used and remove them from memory  )

            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types

            //Independent in memory
            var a = 10;
            var b = a;

            //a is gonna be 10 since integers are value types and when we copy a value type to another is stored in memory
            b++;

            Console.WriteLine(string.Format("a = {0}, b = {1}", a, b));

            //In reference types they refer to the memory adress  created fro them so if one changes it changes 
            //the memory also and the other
            var myArray = new int[3] { 1, 2, 3 };
            var mySecondArray = myArray;
            mySecondArray[0] = 0;

            //Both array indexes 0 will be 0 
            Console.WriteLine(string.Format("myArray[0] : {0}, mmySecondArray[0] : {1}", myArray[0], mySecondArray[0]));

            
            //We will get 2 since number is a value type in the scope of main method
            var number = 2;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);

        }


        //The scope of int number is limited to Increment method only
        public static void Increment(int number)
        {
            
            number += 10;

        }

        //Since now the type of the parameter is a reference type the object will be passed here won't be copied but it's reference will be copied
        public static void MakeOld(Person person) {

            person.Age += 20;

        }



    }
    
}
