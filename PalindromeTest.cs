using System;
using LibraryChallangeLib;
using Xunit;


namespace TestingChallangexUnit
{
    public class PalindromeTest
    {
        readonly Palindrome P = new Palindrome();

        [Fact]
        public void T1()
        {
            string test = ("nurses run");
            bool value = P.isPalidrome(test);
            Assert.Equal(true, value);
        }

        [Fact]
        public void T2()
        {
            string test = ("racecaR");
            bool value = P.isPalidrome(test);
            Assert.Equal(true, value);
        }

        [Fact]
        public void T3()
        {
            string test = ("1221");
            bool value = P.isPalidrome(test);
            Assert.Equal(true, value);
        }

        [Fact]
        public void T4()
        {
            string test = ("never odd, or even.");
            bool value = P.isPalidrome(test);
            Assert.Equal(true, value);
        }

        [Fact]
        public void T5()
        {
            string test = ("one two one");
            bool value = P.isPalidrome(test);
            Assert.Equal(false, value);
        }

        [Fact]
        public void T6()
        {
            string test = ("123abccba123");
            bool value = P.isPalidrome(test);
            Assert.Equal(false, value);
        }

    }
}
