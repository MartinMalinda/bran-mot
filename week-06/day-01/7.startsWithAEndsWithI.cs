using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var startsWithAEndsWithI = cities.Where(city => city.StartsWith("A", StringComparison.Ordinal) && city.EndsWith("I", StringComparison.Ordinal)).ToList();
            startsWithAEndsWithI.ForEach(Console.WriteLine);
        }
    }
}
