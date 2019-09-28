using System;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowerN(2,3));
        }

        public static int PowerN(int n, int exponent)
        {
            if (exponent == 1)
            {
                return n;
            }
            else
            {
                return n * PowerN(n, exponent - 1);
            }
        }
    }
}
