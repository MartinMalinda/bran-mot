using System;

namespace Factorio
{
    class Program
    {
        public static int Factorio (int valueToCalculate)
        {
            int factorial = 1;
            for (int i = valueToCalculate; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        static void Main(string[] args)
        {
            // - Create a function called `Factorio`
            //   that returns it's input's factorial
            Console.WriteLine(Factorio(7));
            Console.ReadLine();
        }
    }
}