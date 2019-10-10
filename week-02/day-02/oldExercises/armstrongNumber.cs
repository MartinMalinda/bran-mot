using System;
using System.Collections.Generic;

namespace oldExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //An Armstrong number is an n - digit number that is equal to the sum of the nth powers of its digits.
            //Let's demonstrate this for a 4-digit number: 1634 is a 4-digit number, raise each digit to the fourth power,
            //and add: 1^4 + 6^4 + 3^4 + 4^4 = 1634, so it is an Armstrong number.
            //For a 3 - digit number: 153 is a 3 - digit number,
            //raise each digit to the third power, and add: 1 ^ 3 + 5 ^ 3 + 3 ^ 3 = 153, so it is an Armstrong number.
            //Exercise

            //Write a simple program to check if a given number is an armstrong number.The program should ask for a number.
            //E.g. if we type 371, the program should print out: The 371 is an Armstrong number.

            Console.WriteLine(IsArmstrong(1634));
        }

        public static string IsArmstrong(int num)
        {
            List<int> digits = new List<int>();
            int sum = 0;
            int digitBreaker = num;
            do
            {
                digits.Insert(0, digitBreaker % 10);
                digitBreaker = digitBreaker / 10;

            } while (digitBreaker > 10);
            digits.Insert(0, digitBreaker);
            int exponent = digits.Count;

            foreach (var digit in digits)
            {
                sum += (int)Math.Pow(digit, exponent);
            }
            if (num == sum)
            {
                return $"{num} is an Armstrong number.";
            }
            else
            {
                return $"{num} is not an Armstrong number.";
            }
        }
    }
}
