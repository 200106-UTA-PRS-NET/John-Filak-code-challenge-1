using System;
using LibraryChallangeLib;
using Xunit;


namespace TestingChallangexUnit
{
    public class PalindromeTest
    {
         readonly Palindrome P  = new Palindrome();

        [Fact]
        public void PalindromeIsPalindrome()
        {
            string test = ("nurses run");
            bool value = P.isPalidrome(test);
            Assert.Equal(true, value);
        }

    }
}
