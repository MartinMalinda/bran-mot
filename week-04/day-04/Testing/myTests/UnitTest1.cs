using System;
using Xunit;
using Testing;
using System.Collections.Generic;

namespace myTests
{
    public class ExtensionTests
    {
        Extension extension = new Extension();

        //[Fact]
        //public void TestAdd_2and3is5()
        //{
        //    Assert.Equal(5, extension.Add(2, 3));
        //}

        //[Fact]
        //public void TestAdd_1and4is5()
        //{
        //    Assert.Equal(5, extension.Add(1, 4));
        //}

        [Theory]
        [InlineData(5, 1)]
        [InlineData(6, 7)]
        [InlineData(12, 3)]
        public void TestAdd(int a, int b)
        {
            Assert.Equal(a+b, extension.Add(a, b));
        }

        [Fact]
        public void TestMaxOfThree_First()
        {
            Assert.Equal(5, extension.MaxOfThree(5, 4, 3));
        }

        [Fact]
        public void TestMaxOfThree_Fhird()
        {
            Assert.Equal(5, extension.MaxOfThree(3, 4, 5));
        }

        [Theory]
        [InlineData(9,1,2)]
        [InlineData(1, 9, 2)]
        [InlineData(1, 2, 9)]
        public void TestMaxOfThree_Fail(int a, int b, int c)
        {
            Assert.Equal(9, extension.MaxOfThree(a, b, c));
        }

        [Fact]
        public void TestMedian_Four()
        {
            Assert.Equal(5, extension.Median(new List<int>() { 7, 5, 3, 5 }));
        }

        [Fact]
        public void TestMedian_Five()
        {
            Assert.Equal(3, extension.Median(new List<int>() { 1, 2, 3, 4, 5 }));
        }

        [Fact]
        public void TestMedian_Fail()
        {
            Assert.Equal(4, extension.Median(new List<int>() { 6, 3, 6, 9, 3, 1, 2, 8, 3, 8, 4, 3, 9 }));
        }

        [Fact]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('a'));
        }

        [Fact]
        public void TestIsVowel_u()
        {
            Assert.True(extension.IsVowel('u'));
        }

        [Fact]
        public void testTranslate_bemutatkozik()
        {
            Assert.Equal("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
        }

        [Fact]
        public void testTranslate_kolbice()
        {
            Assert.Equal("lavagovopuvus", extension.Translate("lagopus"));
        }
    }
}
