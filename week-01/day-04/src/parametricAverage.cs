using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            //get the quantity of numbers to sum and average
            Console.WriteLine("Please enter a number: ");
            int num = int.Parse(Console.ReadLine());

            //create the array
            int[] userNumbers = new int[num];
            int sum = 0;
            int average;

            //fill the array and update the sum
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Please enter number " + (i+1));
                userNumbers[i] = int.Parse(Console.ReadLine());
                sum = sum + userNumbers[i];
            }

            //calculate average
            average = sum / num;

            //output the sum and average
            Console.WriteLine("Sum: " + sum +", Average: " + average);
        }
    }
}