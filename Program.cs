/*
 Author: Harrison Chona
 Date: 09/19/2019
 Description: With this project. I created a cool little robot with some personality.
 He asks you a few questions and interacts with your responses.

 In this example I use:
 -Alternative methods
 -If else
 -Try catch
*/

using System;

namespace D3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your First and Last name.");

            try
            {
                
                string value = Console.ReadLine();

                Console.WriteLine("Hello " + value + "!");
            }

            catch
            {
                Console.WriteLine("Error... Please enter your First and Last name, separated by a space."); 
            }

            Console.WriteLine("What is your favorite color?");

            try
            {
                string value2 = Console.ReadLine();

                Console.WriteLine("My favorite color is also " + value2 + "!");
            }

            catch
            {
                Console.WriteLine("Error... Please enter your favorite color!");
            }

        }

        private static int World_Destroyer(int value3)
        {
            Console.WriteLine("... Do you want to be my friend? Type 0 for yes, 1 for no.");


            try
            {

                string input = Console.ReadLine();

                int value4 = int.Parse(input);

                if (value3 == 0)
                {
                    Console.WriteLine("Well, you just made my day!");
                }

                else if (value3 == 1)
                {
                    Console.WriteLine("Well I was just kidding... And will use your identity to conquer the world!!!");
                }
            }

            catch
            {
                Console.WriteLine("Error... Enter the value 0 or 1");
            }
        }

    }
}
