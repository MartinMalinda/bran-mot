using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var squaredNumbers = n.Where(number => number > 0).Select(number => number * number).ToList();
            squaredNumbers.ForEach(Console.WriteLine);
        }
    }
}
