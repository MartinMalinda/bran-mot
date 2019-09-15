using System;

namespace PrintAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `numbers`
            int[] numbers = { 4, 5, 6, 7 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}