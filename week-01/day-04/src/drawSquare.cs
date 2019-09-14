using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%%
            // %    %
            // %    %
            // %    %
            // %    %
            // %%%%%%
            //
            // The square should have as many lines as the number was

            Console.WriteLine("Please enter a number for the width and height of a square: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i == 1 || i == num)
                {
                    for (int j = 0; j < num; j++)
                    {
                        Console.Write("%");
                    }
                }
                else
                {
                    Console.Write("%");
                    for (int k = 0; k < num -2; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("%");
                }
                Console.WriteLine();
            }
        }
    }
}
