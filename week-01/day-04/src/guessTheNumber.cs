using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int storedNumber = 8;
            Console.WriteLine("Guess the number: ");
            int userNumber = int.Parse(Console.ReadLine());

            while (userNumber != storedNumber)
            {
                if (storedNumber > userNumber)
                {
                    Console.WriteLine("The stored number is higher.");
                    Console.WriteLine("Try again: ");
                    userNumber = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("The stored number is lower.");
                    Console.WriteLine("Try again: ");
                    userNumber = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("You found the number: " + userNumber);
         }
    }
}