using Calculator.Helpers;
using System;
using System.Collections.Generic;
using System.Text;


namespace Calculator.Models
{
    public static class Calc
    {
        public static decimal Avg(List<int> numbers)
        {
            return HelperMethods.CalculateAverage(numbers);
        }
        public static int Max(List<int> numbers)
        {
            return HelperMethods.FindMaxNumber(numbers);
        }

        public static int Min(List<int> numbers)
        {
            return HelperMethods.FindMinNumber(numbers);
        }

        //Square Function x2
        public static int Sum(List<int> numbers)
        {
            return HelperMethods.Sum(numbers);
        }

    }
}