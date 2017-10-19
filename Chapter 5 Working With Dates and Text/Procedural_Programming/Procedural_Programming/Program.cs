using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedural_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("Write a name and I will reverse it");

            var name = Console.ReadLine();
            var reversedArray = ReverseName(name);

            Console.WriteLine(reversedArray);

            Console.WriteLine("Write numbers seperated with comma and i ll show you unique ones");

            
            var numbers = new List<int>() { 5, 4, 4, 3 };
            
            GetUniqueNumbers(numbers);
            
            
        }


        
        
        
        //******METHODS***********


        //- First we use the public keyword then the static so we can call it anywhere  directly
        public static string ReverseName(string name)
        {
            char[] charArray = name.ToCharArray();

            Array.Reverse(charArray);

            var reversed = string.Join("", charArray);

            return reversed;


            //OR we could write return string.Join("", charArray);
        }


        public static void GetUniqueNumbers(List<int> numbers)
        {
            var uniqueNumbers = new List<int>();
           

            uniqueNumbers = numbers.Distinct().ToList();
            foreach (var uniqueNumber in uniqueNumbers)
            {
                Console.WriteLine(uniqueNumber);
            }
        }

        


    }
}
