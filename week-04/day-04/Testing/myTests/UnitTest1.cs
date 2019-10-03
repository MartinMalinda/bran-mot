using System;
using Xunit;
using Testing;
using System.Collections.Generic;

namespace myTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData ("hello")]
        [InlineData("this is dog")]
        public void Test1(string testString)
        {
            Assert.IsType<Dictionary<char,int>>(CountLetters.LetterCount(testString));
        }
    }
}
