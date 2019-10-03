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
            AnagramChecker myAnagram = new AnagramChecker();
            Assert.True(myAnagram.Anagram("dog", "god"));
        }

        [Fact]
        public void Test2()
        {
            AnagramChecker myAnagram = new AnagramChecker();
            Assert.True(myAnagram.Anagram("hello", "go away"));
        }
    }
}
