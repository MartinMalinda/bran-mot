using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string.

            string myString = "I like TO uSe uPpER and LoWeRCASe";

            var upperCaseLetters = myString.ToCharArray().Where(character => Char.IsUpper(character)).ToList();
            upperCaseLetters.ForEach(Console.WriteLine);

        }
    }
}
