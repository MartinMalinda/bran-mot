using System;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`
            int[] ai = new int[] { 3, 4, 5, 6, 7 };
            int sum = 0;
            foreach (var value in ai)
            {
                 sum = sum + value;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}