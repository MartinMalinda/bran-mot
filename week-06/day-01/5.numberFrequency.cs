using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of numbers in the following array:

            int[] n = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var numberCount = n.GroupBy(number => number).ToList();
            numberCount.ForEach(num => Console.WriteLine(num.Key + ": " + num.Count()));
        }
    }
}
