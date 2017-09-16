using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Multidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            //In C# except single dimension we have multidimensional arrays
            //They are used for structures such as matrix


            //This is a multidimensional array means it will have 3 rows of 5 columns each

            //Rectangular has same columns iin each row
            var matrix = new int[3, 5]
            {

                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 }
            };

            //Jagged
            var array = new int[3][];

            array[0] = new int[4];
            array[1] = new int[3];
            array[2] = new int[2];


            //The array type is a class and some predefined properties and methods are 
            //Length
            //Clear()
            //Copy()
            //IndexOf()
            //Reverse()
            //Sort()


            int[] numbers = new int[] { 3, 7, 9, 14, 3 };

            //Length property returns the size of the array
            Console.WriteLine("Length of the array is" + numbers.Length);

            //IndexOf return the index
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 is " + index);


            //Clear() sets items specific value. First parameter is the array,second the value and third how many to change
            Array.Clear(numbers, 0, 3);

            Console.WriteLine();
            Console.WriteLine("How clear works ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            //Copy() copies array to another array
            int[] numbers2 = new int[3];
            Array.Copy(numbers, numbers2, 3);

            Console.WriteLine();
            Console.WriteLine("How copy works");
            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }


            //Sort() It sorts by smaller to bigger
            Array.Sort(numbers);

            Console.WriteLine("How Sort() works");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }



            //Reverse() it reverses the array from bigger to smaller
            Array.Reverse(numbers);

            Console.WriteLine("How Reverse() works");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }





        }
    }
}
