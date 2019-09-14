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
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was

            int num = 8;

            //begin loop of total rows
            for (int i = 0; i < num; i++)
            {
                //render the first and last rows as all X's
                if (i == 0 || i == num-1)
                {
                    for (int j = 0; j < num; j++)
                    {
                        Console.Write("X");
                    }
                }
                else
                {
                    //write the initial X
                    Console.Write("X");
                    //start the variable placement of X's
                    for (int k = 0; k < (i-1); k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("X");
                    for (int l = 0; l < (num - i-2); l++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
    }
}