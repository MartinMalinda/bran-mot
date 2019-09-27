using System;

namespace recursion
{
    class Program
    {
        //Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
        static void Main(string[] args)
        {
            Console.WriteLine(NumberAdder(3));
        }

        public static int NumberAdder(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return n + NumberAdder(n - 1);
        }
    }
}
