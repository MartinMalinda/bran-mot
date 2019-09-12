using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;

            Console.WriteLine("The value of a is: " + a + " and b is: " + b);

            int swap = a;
            a = b;
            b = swap;

            Console.WriteLine("The new value of a is: " + a + " and b is: " + b);

        }
    }
}