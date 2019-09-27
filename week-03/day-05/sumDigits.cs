using System;

namespace recursion
{
    class Program
    {
        //Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
        static void Main(string[] args)
        {
            Console.WriteLine(SumDigits(345));
        }

        public static int SumDigits(int n)
        {
            if (n < 10)
            {
                return n;
            }
            return  n%10 + SumDigits(n / 10);
        }
    }
}
