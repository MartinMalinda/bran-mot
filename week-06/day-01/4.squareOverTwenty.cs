using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:

            int[] n = { 3, 9, 2, 8, 6, 5 };

            var squareLargerThanTwenty = n.Where(number => number * number > 20).ToList();
            squareLargerThanTwenty.ForEach(Console.WriteLine);
        }
    }
}
