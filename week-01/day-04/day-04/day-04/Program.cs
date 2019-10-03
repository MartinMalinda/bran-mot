using System;

namespace GreenFox
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

            //Console.WriteLine("How big of a pyramid do you want to make?");
            //int height = int.Parse(Console.ReadLine());
            int height = 8;
            string star = "*";
            string blank = " ";

            //render top half
            for (int rows = 1; rows <= height/2 ; rows++)
            {
                //calculate spaces
                for (int spaces = 1; spaces <= height/2 - rows; spaces++)
                {
                    Console.Write(blank);
                }
                for (int stars = 0; stars < 2*rows-1; stars++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
            //render bottom half
            for (int bottomRows = 1; bottomRows <= height/2; bottomRows++)
            {
                //calculate spaces
                for (int bottomSpaces = 0; bottomSpaces < bottomRows-1; bottomSpaces++)
                {
                    Console.Write(blank);
                }
                for (int bottomStars = 0; bottomStars < height-bottomRows-1; bottomStars++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }

        }
    }
}


