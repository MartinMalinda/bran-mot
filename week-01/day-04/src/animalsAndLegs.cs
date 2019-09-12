using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.WriteLine("Hey Farmer! How many chickens do you have?");
            string numberOfChickens = Console.ReadLine();
            Console.WriteLine("Cool! How many pigs do you have?");
            string numberOfPigs = Console.ReadLine();
            Console.WriteLine("That means you can eat: " + Convert.ToDouble(numberOfChickens)*2 + " chicken legs and " + Convert.ToDouble(numberOfPigs)*4 + " pig\'s feet!");
        }
    }
}