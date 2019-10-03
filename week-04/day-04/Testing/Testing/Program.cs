using System;
using System.Collections.Generic;

namespace Testing
{
    public class MathOperations
    {
        public MathOperations() { }
        public int SumAll(List<int> numbersToSum)
        {
            int sum = 0;

            foreach (var number in numbersToSum)
            {
                sum += number;
            }

            return sum;
        }
        public int? SumAll(List<int?> numbersToSum)
        {
            int? sum = null;
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
