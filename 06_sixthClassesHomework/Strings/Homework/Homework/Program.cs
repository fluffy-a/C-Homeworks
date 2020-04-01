using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //* Print individual characters of the string in reverse order. *Example: we love c# *Expected Output : #c evol ew
            //string lettersWords = "We,love,C#";

            //string wordLetters = "We love C#";
            //string reverse = "";

            //for (int i = wordLetters.Length-1; i>=0 ; i--)
            //{
            //    reverse = reverse + wordLetters[i];
            //}
            //Console.WriteLine(reverse);


            //Task 2
            //* Count the total number of words in a string entered by the user. * 

            //Console.WriteLine("Input a quote that u like it");
            //string InputFromUser = Console.ReadLine();

            //string[] words = InputFromUser.Trim().Split(' ');

            //Console.WriteLine($"The number of words in the quote is  {words.Length}");


            //Task 3
            //Find maximum occurring character in a string* 
            //Example: "We want this situation with covid-19 to ends!" * 
            //Expected Output: The highest frequency of character 't' appears number of times : 6


            string letterAboutSituation = "We want this situation with covid-19 to ends!";
            char[] sentence = letterAboutSituation.ToCharArray();
            char sign = ' ';
            int count = 0;
            int j;
            int finalcounter = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                count = 1;
                for (j = i + 1; j < sentence.Length; j++)
                {
                    if (sentence[i] == sentence[j] && sentence[i] != ' ')
                    {
                        count++;
                        if (count >= finalcounter)
                        {
                            finalcounter = count;
                            sign = sentence[j];
                        }
                    }


                }
            }

            Console.WriteLine(sentence);
            Console.WriteLine($"The highest frequency of {sign} appears number of times :  {finalcounter}");



            //Task 4    
            //"The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!"
            //* Print the whole text after "," in the console. *Bonus - Try to do that without counting the characters till "," by yourself :)

            string group = "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!";

            var chars = new[] {','};

            string[] afterChar = group.Split(chars);


            Console.WriteLine(afterChar[1]); // index 0 is before (,), index 1 is after (,)



            //Task 5
            //* Display the Day properties(year, month, day, hour, minute, second) from the today's date. *Expected Output : *year = 2020
            //* month = 3
            //* day = 26
            //* hour = 23
            //* minute = 12
            //* second = 22

            var today = DateTime.Now;
            Console.WriteLine(today);


            int day = today.Day;
            int month = today.Month;
            int year = today.Year;
            int hour = today.Hour;
            int minute = today.Minute;
            int second = today.Second;

            Console.WriteLine($"{day}Day {month}Month {year}Year ,{hour}:{minute}:{second}sec");


            //Task 6
            // *Find the leap years between 2008 and 2020. * Expected output: *2008 is a leap year. 
            //* 2012 is a leap year. * 2016 is a leap year. * 2020 is a leap year.
            //* Hint - make some researches of DateTime methods, you will find interesting ones that might help you;)



            int year1;

            for (year1 = 2008; year1 <= 2020; year1++)
            {
                if (DateTime.IsLeapYear(year1))
                {
                    Console.WriteLine($"{year1} is leap year!");
                }
            }





            Console.ReadLine();
        }
    }
}
