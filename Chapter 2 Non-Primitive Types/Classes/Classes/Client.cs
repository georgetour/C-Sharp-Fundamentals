using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Client
    {

        //public keyword means that they are accessible everywhere we call them


        //Fieds
        public int id;
        public string firstName;
        public string lastName;
        public bool membershipActive;



        //Methods with void don't return anything they just do something 
        //and with the keyword return they return something
        public void showDetails()
        {

            //By adding + to a string it concatinates with the next
            Console.WriteLine("id " +
                id + " first name " +
                firstName + " membership active: " +
                membershipActive
           );

        }
    }
}
