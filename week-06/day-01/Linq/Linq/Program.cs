using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to convert a char array to a string.

            char[] myCharacters = { 'a', 'l', 'l', 'i', 'u', 'm' };

            var myString = String.Join("", myCharacters.Select(character => character));
            Console.WriteLine(myString);
        }
    }
}
