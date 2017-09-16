using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays has fixed size  
            var myArray = new int[] { 1, 3, 4 };

            //Lists have dynamic size
            var numbers = new List<int>() { 1,2,3,4};


            //Useful Methods
            //Add() in lists you can add something in arrays you can't since they are prefixed
            numbers.Add(1);


            //Adds array or list to existing
            numbers.AddRange(new int[3] { 10, 15, 20 });


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //IndexOf and LastIndexOf
            Console.WriteLine("Index of 1:" +numbers.IndexOf(1));

            Console.WriteLine("Last Index of 1:" + numbers.LastIndexOf(1));


            //Count counts the mebers of the list
            Console.WriteLine("Count: " + numbers.Count);

            
            //We will get application exception since in C# we can't modify a a list in a foreach loop
            //foreach (var number in numbers)
            //{
            //    if (number == 1) {
            //        numbers.Remove(number);
            //    }
                
            //}


            //If we want to remove all 1 from our list This will work
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Clear() remove all elements from the list
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);

        }
    }
}
