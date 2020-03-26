using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write type of aritmetic operation ");

            Console.WriteLine(" + ");
            Console.WriteLine(" - ");
            Console.WriteLine(" * ");
            Console.WriteLine(" / ");
            Console.WriteLine("&");
            Console.WriteLine("s");

            if (Console.ReadLine() == "&" && Console.ReadLine() == "s")
            {
                Console.WriteLine("Please write correct operation or the program will be closed! ");
                return;
            }



            while (true)
            {
                Console.WriteLine("Please select an options: ");

                string op = Console.ReadLine();

                string firstInputnumber;
                string secondInputnumber;

                Console.WriteLine("Enter the first number");

                firstInputnumber = Console.ReadLine();
                int firstNumber;

                while (!int.TryParse(firstInputnumber, out firstNumber))
                {
                    Console.WriteLine("Invalid input number.The aplication will automatically close. ");
                    return;
                }

                Console.WriteLine("Now enter the second number");
                secondInputnumber = Console.ReadLine();
                int secondNumber;

                while (!int.TryParse(secondInputnumber, out secondNumber))
                {
                    Console.WriteLine("Invalid input number.The aplication will automatically close. ");
                    return;
                }

                switch (op)
                {
                    case "+":
                        int result = Sum(firstNumber, secondNumber);
                        Console.WriteLine($"The result is {result}");
                        break;

                    case "-":
                        int anotherResult = Subtraction(firstNumber, secondNumber);
                        Console.WriteLine($"The result is {anotherResult}");
                        break;

                    case "*":
                        int anotherResult1 = Multiply(firstNumber, secondNumber);
                        Console.WriteLine($"The result is  {anotherResult1}");
                        break;

                    case "/":
                        int anotherResult3 = Divide(firstNumber, secondNumber);
                        if (firstNumber == 0 || secondNumber == 0)
                        {
                            Console.WriteLine("Division with zero is not possible!");
                            break;

                        }

                        Console.WriteLine($"The result is {anotherResult3} ");
                        break;


                    default:
                        Console.WriteLine("Invalid operation selected! The aplication will automatically close.");
                        break;
                }

                
                if (Console.ReadLine() == "s" || Console.ReadLine() == "S")
                {
                    Console.WriteLine("Invalid operation selected! The aplication will automatically close.");
                    return;
                
                }

                Console.ReadLine();
            }
        }



        public static int Sum(int firstNumber, int secondNumber)
                {
                    return firstNumber + secondNumber;

                }
                public static int Subtraction(int firstNumber, int secondNumber)
                {
                    return firstNumber - secondNumber;

                }
                public static int Divide(int firstNumber, int secondNumber)
                {
                    return firstNumber / secondNumber;

                }
               
                public static int Multiply(int firstNumber, int secondNumber)
                {
                    return firstNumber * secondNumber;

                }





    }
}
