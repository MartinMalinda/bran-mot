using System;
using System.IO;
using System.Collections.Generic;

namespace DecipherText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StarReplace("hetjdtu", 0));
        }

        //Given a string, compute recursively a new string where all the adjacent chars are now separated by a*

        public static string StarReplace(string input, int n)
        {
            if (n != input.Length - 1)
            {
                return input[n] + "*" + StarReplace(input, n + 1);
            }
            return input[n] + "";
        }
    }
}
