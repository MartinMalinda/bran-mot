using System;

namespace GreenFox
{
    class Program
    {
        static public int[] Unique (int[] arrayOfNumbers)
        {
            int[] uniqueNumbers = new int[0];
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                for (int nextNumber = i + 1; nextNumber < arrayOfNumbers.Length; nextNumber++)
                {
                    if (arrayOfNumbers[i] == arrayOfNumbers[nextNumber])
                    {
                        arrayOfNumbers[nextNumber] = 0;

                    }
                }
            }
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if(arrayOfNumbers[i] != 0)
                {
                    Array.Resize(ref uniqueNumbers, uniqueNumbers.Length + 1);
                    uniqueNumbers[uniqueNumbers.Length - 1] = arrayOfNumbers[i];
                }
            }
            
            return uniqueNumbers;
        }
        static void Main(string[] args)
        {
            //  Create a method that takes an array of integers as a parameter
            //  Returns an array of integers where every integer occurs only once

            //  Example
            //Console.WriteLine(Unique(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }));
            //  should print: `[1, 11, 34, 52, 61]`
            foreach (int number in Unique(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }))
            {
                Console.WriteLine(number);
            }
        }
    }
}