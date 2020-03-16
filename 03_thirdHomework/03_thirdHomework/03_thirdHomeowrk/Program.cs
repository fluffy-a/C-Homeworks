using System;

namespace _03_thirdHomeowrk
{
    class Program
    {
        static void Main(string[] args)
        {

            //EXERCISE 01:

            //Get an input number from the console
            //Print all numbers from 1 to that number
            //Get another input number from the console
            //Print all numbers from that number to 1

            Console.WriteLine("Write a number");

            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(i);

            }
            Console.ReadLine();


            Console.WriteLine("Write another number");
            int input1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 10; i > input1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            //EXERCISE 02:
            //Get an input number from the console
            //Print all even numbers starting from 2
            //Get another input number from the console
            //Print all odd numbers starting from 1

            Console.WriteLine("Write a number");
            int input3 = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < input3; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            Console.WriteLine("Write a number");
            int input4 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < input3; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();


            //EXERCISE 03:
            //Create an array with names
            //Give an option to the user to enter a name from the keyboard
            //After entering the name put it in the array
            //Ask the user if they want to enter another name(Y / N)
            //Do the same process over and over until the user enters N
            //Print all the names after user enters N
            //Hint: we need to use endless loop until user enter N, then we want to "break" the loop


            string[] outputNames = new string[] { };
            int index = 0;
            string validation;
            for (int i = 0; ; i++)
            {
                Console.WriteLine("Do u wanna enter a name? Enter y/n");
                validation = Console.ReadLine();
                if (validation == "y")
                {
                    Array.Resize(ref outputNames, outputNames.Length + 1);
                    Console.WriteLine("Enter the next name");
                    string anotherName = Console.ReadLine();
                    outputNames[index] = anotherName;
                    index++;
                    continue;
                }
                else if (validation == "n")
                {
                    foreach (var item in outputNames)
                    {

                        Console.WriteLine(item);
                    }
                    break;
                }
                else
                    Console.WriteLine("invalid input");
            }Console.ReadLine();
            
        }
    }
}

