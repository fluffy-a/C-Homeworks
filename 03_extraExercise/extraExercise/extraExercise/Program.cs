using System;

namespace extraExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to find the sum of first 10 natural numbers
            //* Hint: The first 10 natural number are: 1 2 3 4 5 6 7 8 9 10
            //1 Exercise

            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum = sum += i;


            //}
            //Console.WriteLine($"The result is: {sum}");




            //Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
            //2 Exercise

            //with for
            //int sum2 = 0;
            //int[] num = new int[10];
            //int average;
            //Console.WriteLine("Please enter 10 numbers");

            //for (int i = 1; i <num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //    sum2 = sum2 + num[i];

            //}
            //Console.WriteLine($"The sum is {sum2}");
            //average = sum2 / 10;
            //Console.WriteLine($"The average is {average}");
            //Console.ReadLine();



            //Declare and init array of 10 integers by your choise. 
            // Find maximum and minimum element in that array and their indexes.
            //3 Exercise

            //int[] numArr = new int[10] { 1, 5, 6, 8, 7, 9, 3, 4, 2, 10};

            //int max = numArr[0];
            //int min = numArr[0];
            //for (int i = 0; i < numArr.Length;i++)
            //{
            //    if (min > numArr[i])
            //    {
            //        min = numArr[i];
            //    }
            //    if (max < numArr[i]) 
            //    {
            //        max = numArr[i];
            //    }

            //}
            //int indexOfMax = Array.IndexOf(numArr, max);
            //int indexOfMin = Array.IndexOf(numArr, min);

            //Console.WriteLine($"The minimum number in the array is {min} and the index is {indexOfMin}");
            //Console.WriteLine($"The maximum number in the array is {max} and the index is {indexOfMax}");
            //Console.ReadLine();



            //arrayWithDuplicates = [1, 4, 6, 3, 4, 5, 9, 3, 2, 9]
            //Write a program in C# Sharp to count a total number of duplicate elements in arrayWithDuplicates
            //4 Exercise

            int[] arrayWithDuplicates = new int[10] { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };
            int i = 0;
            int count = 0;
            int j;
            for (i = 0; i < arrayWithDuplicates.Length; i++)
            {
                for ( j = i + 1; j < arrayWithDuplicates.Length; j++)
                {
                      if (arrayWithDuplicates[i] == arrayWithDuplicates[j])
                    {
                count++;
                break;
                    }
                }

            }
    Console.WriteLine($"Total number of duplicates in the array is {count}");
            Console.ReadLine();

            //  oddEvenArray = [10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49]
            //Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays
            //5 Exercise

            int[] oddEvenArray = new int[12] { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };
            int[] oddArray = new int[] { };
            int[] evenArray = new int[] { };
            int oddIndex = 0;
            int evenIndex = 0;

            for ( i = 0; i < oddEvenArray.Length; i++)
            {
                if (oddEvenArray[i] % 2 == 0)
                {
                    Array.Resize(ref evenArray, evenArray.Length + 1);
                    evenArray[evenIndex] = oddEvenArray[i];
                    evenIndex++;
                }
                else if (oddEvenArray[i] % 2 != 0)
                {
                    Array.Resize(ref oddArray, oddArray.Length + 1);
                    oddArray[oddIndex] = oddEvenArray[i];
                    oddIndex++;
                }
            }
            Console.WriteLine("Even array");
            foreach (var item in evenArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Odd array");
            foreach (var item in oddArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();



            //Write a program in C# Sharp to read any Day Number in integer (from 1 to 7) and display on screen
            //the day with strings. Example: user enters 1, you should print Monday.
            //6 Exercise

            Console.WriteLine("Please enter a number to tell u the month");
            var input = Console.ReadLine();
            int num;
            bool parsingSuccsess = int.TryParse(input, out num);
            //also i can use this here int number = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:Console.WriteLine("Invalid");

                    break;
            }

            //  Write a program in C# Sharp to ask the user to enter a username. After that user should provide a password.
            //   Create a logic when user enters specific username to provide a correct password for that user, and when that
            //happens you should print on the screen "You are logged in successfully".
            //If username or password are invalid or don't correspond "Incorrect username or password" should be print on the screen and
            //repeat the proccess from begining while he / she doesn't input correct username and password.
            //Note: Every element in userNames corresponds with the element in passwords at same index.
            //Example: password for "user1" is "first", password for "user2" is "second", password for "user3" is "third
            //7 Exercise




            string[] userNames = { "user1", "user2", "user3" };
            string[] passwords = { "first", "second", "third" };

            while (true)
            {
                Console.WriteLine("Enter your username");
                string userInput = Console.ReadLine();
                Console.WriteLine("Please enter your password:");
                string passInput = Console.ReadLine();

                if (userInput == userNames[0] && passInput == passwords[0])
                {
                    Console.WriteLine("You are logged in successfully");
                    break;
                }
                else if (userInput == userNames[1] && passInput == passwords[1])
                {
                    Console.WriteLine("You are logged in successfully!");
                    break;
                }
                else if (userInput == userNames[2] && passInput == passwords[2])
                {
                    Console.WriteLine("You are logged in successfully!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password!");
                }

            }
            Console.ReadLine();

        }
    }
}
