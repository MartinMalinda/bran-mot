using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Enter two numbers, one at a time: ");

            double userNumberOne = double.Parse(Console.ReadLine());
            double userNumberTwo = double.Parse(Console.ReadLine());

            if(userNumberOne > userNumberTwo)
            {
                Console.WriteLine("Your first number is bigger");
            }else if (userNumberTwo > userNumberOne)
            {
                Console.WriteLine("Your second number is bigger");
            }
            else
            {
                Console.WriteLine("Your numbers are the same");
            }
        }
    }
}