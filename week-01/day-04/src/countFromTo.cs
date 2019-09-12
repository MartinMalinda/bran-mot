using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
            Console.WriteLine("Enter two numbers, one at a time :");
            int userNumberOne = int.Parse(Console.ReadLine());
            int userNumberTwo = int.Parse(Console.ReadLine());

            if (userNumberTwo < userNumberOne)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                Console.WriteLine("First number: " + userNumberOne + ", second number: " + userNumberTwo);
                for (int i = userNumberOne; i < userNumberTwo; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}