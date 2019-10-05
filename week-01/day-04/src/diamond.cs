using System;

namespace ExpressionsAndControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  ***** 
            //   ***  
            //    *
            //
            // The diamond should have as many lines as the number was


            //Console.WriteLine("How tall of a pyramid do you want to create?");
            //int num = int.Parse(Console.ReadLine());
            int num = 7;
            Console.WriteLine();
            int halfwayPoint = 0;
            if (num%2 == 0)
            {
                halfwayPoint = (num / 2);
            }
            else
            {
                halfwayPoint = (num / 2) + 1;
            }

            for (int rows = 1; rows <= halfwayPoint; rows++)
            {
                for (int spaces = halfwayPoint-rows; spaces > 0; spaces--)
                {
                    Console.Write(" ");
                }
                for (int stars = 0; stars < (rows*2)-1; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int rows = 1; rows <= halfwayPoint; rows++)
            {
                for (int spaces = rows ; spaces > 0 ; spaces--)
                {
                    Console.Write(" ");
                }
                for (int stars = 0; stars < num-(2*rows); stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
