using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
            string[] abc = new string[] { "first", "second", "third" };
            string swap = abc[0];
            abc[0] = abc[2];
            abc[2] = swap;
            foreach (var value in abc)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}