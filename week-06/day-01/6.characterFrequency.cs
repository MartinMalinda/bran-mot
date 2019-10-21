using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of characters in a given string.

            string myString = "puppies eat a lot of spaghetti";

            var characterCount = myString.ToCharArray().GroupBy(character => character).ToList();
            characterCount.ForEach(character => Console.WriteLine(character.Key + ": " + character.Count()));
        }
    }
}
