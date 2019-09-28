using System;

namespace recursion
{
    class Program
    {
        //Find the greatest common divisor of two numbers using recursion.
        static void Main(string[] args)
        {
            Console.WriteLine(Gcd(48, 32));
        }

        public static int Gcd(int a, int b)
        {
            if (a > b)
            {
                return Gcd(a - b, b);
            } else if (b > a)
            {
                return Gcd(a, b - a);
            }else
            {
                return a;
            }
        }
    }
}
