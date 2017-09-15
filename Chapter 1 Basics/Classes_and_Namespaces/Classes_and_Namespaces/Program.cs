using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //A class is a block of code that holds data for some specific functionality 
            //It combines related variables(fields) and functions (methods)
            //To crate a class right click in your solution and Add class or top bar Project -> Add Class

            //Now we are at class Program and right in the solution explorer you can see it Program.cs 

            //We created a class Client

            //By using the new keyowrd we create a new instance of the class and we can use its fields or methods

            Client client = new Client();

            //We access them with a . and u see that they appear with Visual Studio's intellisense
            client.id = 1;
            client.firstName = "George";
            client.membershipActive = true;

            //Calling the method showdetails from client class 
            client.showDetails();


            //A namespace is something that has many classes in it
            //We have been using Console.Writeline which Console is a class of namespace System and Writeline a method of that class
            System.Console.WriteLine("Using the namespace System");

            //As you can see in top we have using system which we are saying that we will use this namespace
            //With the using keyword we refer to the namespace we want to use 


        }
    }
}
