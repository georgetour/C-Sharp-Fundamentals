using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_With_Text_Exercises
{
    class Exercise_4
    {
        /*
         Write a program and ask the user to enter a few words separated by a space. 
         Use the words to create a variable name with PascalCase. 
         For example, if the user types: "number of students", 
         display "NumberOfStudents". 
         Make sure that the program is not dependent on the input. 
         So, if the user types "NUMBER OF STUDENTS", 
         the program should still display "NumberOfStudents"
             
        */


        public static void PascalCase()
        {
            Console.WriteLine("Write some text separated by a space and I will make them PascalCase");

            var input = Console.ReadLine();

            char[] array = input.ToCharArray();

            //For the first character
            if(array.Length > 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }


            //For first characters after spaces
            for (int i = 1; i < array.Length; i++)
            {
                if(array[i - 1] == ' ')
                    //Console.WriteLine(i-1);
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }

            var result = new string(array);
            result = result.Replace(" ", String.Empty);
            Console.WriteLine(result);


        }


    }
}
