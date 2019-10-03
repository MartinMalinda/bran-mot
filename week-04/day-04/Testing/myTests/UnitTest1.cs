using System;
using Xunit;
using Testing;
using System.Collections.Generic;

namespace myTests
{
    public class UnitTest1
    {
        //0, 1, 1, 2, 3, 5, 8, 13, 21 
        [Theory]
        [InlineData (5)]
        [InlineData(8)]
        public void Test1(int testInt)
        {
            Assert.Equal(5, Fibonacci.GetFibonacciValue(testInt));
        }
    }
}
