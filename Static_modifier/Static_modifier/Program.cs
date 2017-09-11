using System;


namespace Static_modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //When we use the static keyword as you see in client class we can call it directly
            //without instansiating

            Console.WriteLine(Client.firstName);


        }
    }
}
