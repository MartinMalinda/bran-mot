using System;

namespace Sum
{
    class Program
    {
        public static int Sum (int endNumber)
        {
            int sum=0;
            for (int i = 0; i <= endNumber; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            // Write a function called `sum` that returns the sum of numbers from zero to the given parameter
            Console.WriteLine(Sum(4));
        }
    }
}