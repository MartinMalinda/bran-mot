using System;

namespace recursion
{
    class Program
    {
        //Define a recursive fibonacci(n) method that returns the nth fibonacci number, with n = 0 representing the start of the sequence.

        static void Main(string[] args)
        {
            //0, 1, 1, 2, 3, 5, 8, 13, 21 

            Console.WriteLine(Fibonacci(8));
        }

        public static int Fibonacci(int n)
        {
            if(n <= 1)
            {
                return n;
            }
            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
    }
}