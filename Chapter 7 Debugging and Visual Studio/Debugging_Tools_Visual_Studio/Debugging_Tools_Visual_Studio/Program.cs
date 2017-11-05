using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging_Tools_Visual_Studio
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);

        }


        public static List<int> GetSmallests(List<int> list, int count)
        {
            var smallests = new List<int> ();

            while (smallests.Count < count)
            {
                var min = GetSmallest(list);
                smallests.Add(min);
                list.Remove(min);
            }


            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {

            //Assume the first number is the smallest
            var min = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (min < list[i])
                {
                    min = list[i];
                }
            }

            return min;
        }
    }
}
