using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.
            Console.WriteLine("Please enter a number:");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber == 0 || userNumber % 2 == 0)
            {
                Console.WriteLine("Your number is even.");
            }
            else
            {
                Console.WriteLine("Your number is odd.");
            }
        }
    }
}