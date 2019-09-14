using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
            int height = 8;
            for (int rows = 0; rows < height; rows++)
            {
                if(rows % 2 == 0)
                {
                    for (int cols = 0; cols < height; cols++)
                    {
                        Console.Write("% ");
                    }
                }
                else
                {
                    for (int cols = 0; cols < height; cols++)
                    {
                        Console.Write(" %");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
