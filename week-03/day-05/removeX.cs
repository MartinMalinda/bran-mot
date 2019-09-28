using System;

namespace recursion
{
    class Program
    {
        //Given a string, compute recursively a new string where all the 'x' chars have been removed.

        static void Main(string[] args)
        {
            Console.WriteLine(RemoveX("xxxxHelloxxxx"));
        }

        public static string RemoveX(string input)
        {
            if (input.Contains("x") == true)
            {
                int index = input.IndexOf("x", 0, input.Length, StringComparison.Ordinal);
                input = input.Remove(index, 1);
                return RemoveX(input);
            }
            return input;
        }
    }
}