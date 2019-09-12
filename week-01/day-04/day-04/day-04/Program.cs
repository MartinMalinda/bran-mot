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
            int userNumber = int.Parse(Console.ReadLine());
            string star = "";
            string blank = "-";
            for (int i = 0; i < userNumber; i++)
            {
                /*for (int j = userNumber; j > 0; j--)
                {
                    blank = blank + "-"
                }*/
                if (i == 0)
                {
                    star = star + "*";
                    blank = blank;
                    Console.WriteLine(blank + star);
                }
                else
                {
                    star = star + "**";
                    Console.WriteLine(blank + star);
                }
                
            }
        }
    }
}