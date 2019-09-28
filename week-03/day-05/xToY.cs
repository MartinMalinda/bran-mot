using System;

namespace recursion
{
    class Program
    {
        //Given a string, compute recursively(no loops) a new string where all the lowercase 'x' chars have been changed to 'y' chars.

        static void Main(string[] args)
        {
            Console.WriteLine(XToY("xxxx"));
        }

        public static string XToY(string input)
        {
            if (input.Contains("x") == true)
            {
                int index = input.IndexOf("x", 0, input.Length, StringComparison.Ordinal);
                input = input.Insert(index, "y");
                input = input.Remove(index+1, 1);
                return XToY(input);
            }
            return input;
        }
    }
}