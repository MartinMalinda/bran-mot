using System;

namespace GreenFox
{
    class Calculator
    {
        static void Main(string[] args)
        {
            // Create a very simplistic calculator: ask for two numbers and an operation (add, subtract, multiply or divide)
            // Based on the operation provided print the result of the calculation.

            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please provide the first number:");

            // Get the first number:
            // int number1 = ...
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please provide the second number:");

            // Get the second number:
            // int number2 = ...
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please provide the operation (add, subtract, multiply or divide):");

            // Get the operation from standard input:
            // string operation = ...
            string operation = Console.ReadLine();
            // use the `switch` statement and the corresponding calculation
            // store the result of the calculation in the `result` variable

            double result = 0.0;

            switch (operation)
            {
                case "add":
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"The result of the calculation is {result}");
                    break;
                case "subtract":
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"The result of the calculation is {result}");
                    break;
                case "multiply":
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"The result of the calculation is {result}");
                    break;
                case "divide":
                    result = (double)firstNumber / secondNumber;
                    Console.WriteLine($"The result of the calculation is {result}");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}