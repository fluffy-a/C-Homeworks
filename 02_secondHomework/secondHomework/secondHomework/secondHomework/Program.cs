using System;

namespace secondHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            //First exercise
            string fruit= "apple";
            string fruit1 = "lemon";
            Console.WriteLine($"My first favorite grapes are: {fruit} and {fruit1}");
           

            string firstNumber = "9";
            string secondNumber = "3";
            Console.WriteLine(firstNumber+secondNumber);
       

            //Second exercise

            int thirdNumber = 10;
            string name = "Aleksandra";
            Console.WriteLine(thirdNumber + "" + fruit);

            //Third exercise
            int n = 102;
            int m = 5;
            int result2 = n / m;
            Console.WriteLine($"U can send: {result2} messages");

            //Fourth exercise
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();
            int parsedNumber;
            bool parsingSuccsess = int.TryParse(input, out parsedNumber);
            if (parsingSuccsess)
            {
                if (parsedNumber % 2 == 0)
                {
                    Console.WriteLine("It`s EVEN");

                }
                else
                {
                    Console.WriteLine("It`s ODD");

                };

            }
            else
            {
                Console.WriteLine("Please enter a correct number");

            };
            Console.ReadLine();




        }
    }
}
