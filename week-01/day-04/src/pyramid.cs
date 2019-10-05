using System;

namespace ExpressionsAndControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.WriteLine("How tall of a pyramid do you want to create?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int rows = 1; rows <= num; rows++)
            {
                for (int spaces = num-rows; spaces > 0; spaces--)
                {
                    Console.Write(" ");
                }
                for (int stars = 0; stars < (rows*2)-1; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
