using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
            Console.WriteLine("How big of a triangle do you want to make?");
            int userNumber = int.Parse(Console.ReadLine());
            string star = "";

            for (int i = 0; i < userNumber; i++)
            {
                star = star + "*";
                Console.WriteLine(star);
            }
        }
    }
}