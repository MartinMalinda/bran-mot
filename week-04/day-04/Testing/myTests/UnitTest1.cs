using System;
using Xunit;
using Testing;
using System.Collections.Generic;

namespace myTests
{
    public class UnitTests
    {
        Sharpie broadPink = new Sharpie("pink", 2);
        Sharpie fineRed = new Sharpie("red", 5, 0);

        [Fact]
        public void TestBroadPink()
        {
            Assert.Equal(100, broadPink.inkAmount);
        }

        [Fact]
        public void TestBroadPinkAfterUse()
        {
            broadPink.Use();
            Assert.Equal(99, broadPink.inkAmount);
        }

        [Theory]
        [InlineData("test", 1)]
        [InlineData("test", 'R')]
        //[InlineData(003133, "purple")]
        public void TestSharpieCreation(string a, int b)
        {
            Assert.IsType<Sharpie>(new Sharpie(a, b));
        }
    }
}
