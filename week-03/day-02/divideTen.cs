using System;
using System.IO;

namespace fileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0
            DivideTen(1);
            DivideTen(10);
            DivideTen(6);
            DivideTen(0);
            
        }
        public static void DivideTen (int a)
        {
            try
            {
                Console.WriteLine(10/a);

            } catch (DivideByZeroException e)
            {
                Console.Error.WriteLine(e);
                Console.WriteLine("Fail");
            }
        }
    }
}
