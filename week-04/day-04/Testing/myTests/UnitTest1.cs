using System;
using Xunit;
using Testing;
using System.Collections.Generic;

namespace myTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<int> myNumbers= new List<int>();
            myNumbers.Add(1);
            myNumbers.Add(2);
            myNumbers.Add(3);

            MathOperations mySum = new MathOperations();

            Assert.Equal(6, mySum.SumAll(myNumbers));    
        }

        [Fact]
        public void TestEmptyList()
        {
            List<int> myNumbers = new List<int>();

            MathOperations mySum = new MathOperations();

            Assert.Equal(0, mySum.SumAll(myNumbers));
        }

        [Fact]
        public void TestOneItemList()
        {
            List<int> myNumbers = new List<int>();
            myNumbers.Add(1);

            MathOperations mySum = new MathOperations();

            Assert.Equal(1, mySum.SumAll(myNumbers));
        }

        [Fact]
        public void TestNullList()
        {
            int? nullInt = null;
            List<int?> myNumbers = new List<int?>();
            myNumbers.Add(nullInt);

            MathOperations mySum = new MathOperations();

            Assert.Equal(null, mySum.SumAll(myNumbers));
        }
    }
}
