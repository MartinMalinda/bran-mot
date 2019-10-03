using System;
using System.Collections.Generic;

namespace Testing
{
    public class Fibonacci
    {
        public static int GetFibonacciValue(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return GetFibonacciValue(n - 2) + GetFibonacciValue(n - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

