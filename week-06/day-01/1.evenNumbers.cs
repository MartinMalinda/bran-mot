using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the even numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbers = n.Where(number => number % 2 == 0);

            evenNumbers.ToList().ForEach(number => Console.WriteLine(number));

            //Experimenting with other variations on the same code

            //var evenNumbers = from number in n
            //                  where number % 2 == 0
            //                  select number;
            //evenNumbers.ToList();

            //foreach (var number in evenNumbers)
            //{
            //    Console.WriteLine(number);
            //}
        }
    }
}
