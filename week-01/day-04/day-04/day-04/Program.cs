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
            //int userNumber = int.Parse(Console.ReadLine());
            int userNumber = 8;
            string star = "*";
            string blank = "-";

            //render the first half of the diamond
            for (int rows = 1; rows <= userNumber/2; rows++)
            {
                //render spaces
                for (int spaces = 1; spaces <= userNumber/2-rows; spaces++)
                {
                    Console.Write(blank);

                }

                //2*i-1 - basically calculate the number of x's in RELATIONSHIP to i

                for (int stars = 1; stars <= 2*rows-1; stars++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
            //render the second half of the diamond
            for (int rows = 1; rows <= userNumber / 2; rows++)
            {
                //render spaces
                for (int spaces = 1; spaces <= rows-1; spaces++)
                {
                    Console.Write(blank);
                }

                //2*i-1 - basically calculate the number of x's in RELATIONSHIP to i

                for (int stars = userNumber - rows; stars > 0; stars--)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }

        }
    }
}
