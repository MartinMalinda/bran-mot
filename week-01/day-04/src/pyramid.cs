using System;

namespace GreenFox
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

            Console.WriteLine("How big of a pyramid do you want to make?");
            int height = int.Parse(Console.ReadLine());
            string star = "*";
            string blank = " ";

            //render top half
            for (int rows = 1; rows <= height ; rows++)
            {
                //calculate spaces
                for (int spaces = 1; spaces <= height - rows; spaces++)
                {
                    Console.Write(blank);
                }
                for (int stars = 0; stars < 2*rows-1; stars++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }

        }
    }
}


