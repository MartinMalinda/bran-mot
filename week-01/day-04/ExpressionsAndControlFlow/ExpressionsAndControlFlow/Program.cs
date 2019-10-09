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
            // 1 ---*
            // 2 --***
            // 3 -*****
            // 4 *******
            // 5 -***** 
            // 6 --***  
            // 7 ---*

            Console.WriteLine("How tall of a pyramid do you want to create?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int halfwayPoint = num/2;
            if (num % 2 != 0)
            {
                for (int rows = 1; rows <= halfwayPoint; rows++)
                {
                    for (int spaces = halfwayPoint - rows+1; spaces > 0; spaces--)
                    {
                        Console.Write(" ");
                    }
                    for (int stars = 0; stars < (rows * 2) - 1; stars++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int rows = 0; rows <= halfwayPoint+1; rows++)
                {
                    for (int spaces = rows; spaces > 0; spaces--)
                    {
                        Console.Write(" ");
                    }
                    for (int stars = 0; stars < num - (2 * rows); stars++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int rows = 1; rows <= halfwayPoint; rows++)
                {
                    for (int spaces = halfwayPoint - rows; spaces > 0; spaces--)
                    {
                        Console.Write(" ");
                    }
                    for (int stars = 0; stars < (rows * 2) - 1; stars++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int rows = 0; rows <= halfwayPoint; rows++)
                {
                    for (int spaces = rows; spaces > 0; spaces--)
                    {
                        Console.Write(" ");
                    }
                    for (int stars = 1; stars < num - (2 * rows); stars++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
