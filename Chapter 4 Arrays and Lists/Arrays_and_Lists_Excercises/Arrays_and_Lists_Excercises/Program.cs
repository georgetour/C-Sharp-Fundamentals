using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Lists_Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            smallestNumbers();

        }

        //1 - When you post a message on Facebook, 
        //depending on the number of people who like your post, 
        //Facebook displays different information.

        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays: [Friend 1]
        // and[Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.

        //Write a program and continuously ask the user to enter different names, 
        //until the user presses Enter (without supplying a name). 
        //Depending on the number of names provided, display a message based on the above pattern.


        public static void facebookMessage()

            {
            Console.WriteLine("Write your friend's names, when you give empty you will see the likes");

                var friends = new List<string>();
                
                while (true)
                {
                    var input = Console.ReadLine();

                    if (!String.IsNullOrEmpty(input)) {
                        friends.Add(input);
                    }
                    

                    var count = friends.Count();

                    if (String.IsNullOrEmpty(input)) {
                        
                        //Console.WriteLine(friends.Count);

                        switch (count)
                        {
                            case 1:
                            Console.WriteLine(String.Format("{0} likes the post",friends[0]));
                            break;

                            case 2:
                            Console.WriteLine(String.Format("{0} and {1} likes the post", friends[0], friends[1]));
                            break;

                            default:
                            if(count > 2)
                                Console.WriteLine(String.Format("{0} and {1} likes the post and we have {2} likes total", friends[0], friends[1], count));
                            break;
        
                         }
                     
                        break;//Break if enter pressed with nothing in it
                    }


                }

          }//End facebookMessage




        // 2- Write a program and ask the user to enter their name.
        // Use an array to reverse the name and then store the result in a new string. 
        //Display the reversed name on the console.



        public static void reverseNameOrder() {

                Console.WriteLine("Write a name and I will reverse it");

                var name = Console.ReadLine();

                char[] charArray = name.ToCharArray();

                Array.Reverse(charArray);

                string reversedArray = string.Join("",charArray);

                //GetType returns th type
                //Console.WriteLine(reversedArray.GetType());

                Console.WriteLine(reversedArray);


            }





        //3- Write a program and ask the user to enter 5 numbers. 
        //If a number has been previously entered, display an error message and ask the user to re-try. 
        //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

        public static void uniqueMembers()
        {
            Console.WriteLine("Write 5 unique numbers");


            var totalNumbers = new List<int>();

            while (totalNumbers.Count() < 5)
            {
                
                var inputNumber = Convert.ToInt32(Console.ReadLine());


                if (totalNumbers.Contains(inputNumber))
                {
                    Console.WriteLine("The number already exists");
                    continue;
                }
                totalNumbers.Add(inputNumber);
           }
            

            totalNumbers.Sort();

            foreach (var number in totalNumbers)
            {
                Console.WriteLine(number);
            }


        }





        //4- Write a program and ask the user to continuously 
        //enter a number or type "Quit" to exit.The list of numbers may include duplicates. 
        //Display the unique numbers that the user has entered.

        public static void uniqueNumbers()
        {
            var numbers = new List<int>();

            var uniqueNumbers = new List<int>();


            Console.WriteLine("Write number and I will diplay unique numbers or write Quit to exit");
            while (true)
            {
                
                var number = Console.ReadLine().ToLower();

               if(number == "quit")
               {
                    break;
               }

               else
               {
                    numbers.Add(Convert.ToInt32(number));
               }

            }

            uniqueNumbers = numbers.Distinct().ToList();
            foreach (var uniqueNumber in uniqueNumbers)
            {
                Console.WriteLine(uniqueNumber);
            }



        }





        //5- Write a program and ask the user to supply a list of 
        //comma separated numbers(e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, 
        //display "Invalid List" and ask the user to re-try; otherwise, 
        //display the 3 smallest numbers in the list.


        public static void smallestNumbers()
        {
            Console.WriteLine("Enter 5 comma seperated numbers");


            var input = Console.ReadLine();

            var numbers = input.Split(',');


            if (numbers.Count() <5 || (numbers.Count() == 0))
            {
                Console.WriteLine("Invalid List");

            }
            else
            {
                Array.Sort(numbers);

                var i = 0;

                foreach (var number in numbers)
                {
                    i++;
                    Console.WriteLine(number);
                    if (i == 3)
                    {
                        break;
                    }
                }
            }
                
            

            

        }


    }
}
