using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Hi User! Enter 5 Integers:");
            int firstInt= int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            int fourthInt = int.Parse(Console.ReadLine());
            int fifthInt = int.Parse(Console.ReadLine());
            int sum = firstInt + secondInt + thirdInt + fourthInt + fifthInt;
            double average = (double)sum / 5; 
            Console.WriteLine("Sum: "+ sum +", Average: " + average);
        }
    }
}

