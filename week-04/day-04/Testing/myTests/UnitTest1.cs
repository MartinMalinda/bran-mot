using System;
using Xunit;
using Testing;

namespace myTests
{
    public class UnitTest1
    {
        //Instantiate your class (arrange, act, assert)
        //Use the Assert.Equal()
        //The expected parameter should be the same string (eg. "apple")
        //The actual parameter should be the return value of the method(eg.myObject.GetApple())
        //Run the test
        //Change the expected value to make the test failing
        //Run the test
        //Fix the returned value to make the test succeeding again
        [Fact]
        public void Test1()
        {
            Apple redApple = new Apple("Red Delicious");

            //Assert.Equal("Red Disgusting", redApple.GetApple());
            Assert.Equal("Red Delicious", redApple.GetApple());

        }
    }
}
