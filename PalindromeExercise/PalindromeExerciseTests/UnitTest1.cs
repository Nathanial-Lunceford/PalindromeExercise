using System;
using Xunit;
using PalindromeExercise;
namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("helicopter", false)]
        [InlineData("skyscraper", false)]
        [InlineData("rotator", true)]
        public void Test1(string palindrome, bool expected)
        {
            var test = new WordSmith();

            var actual = test.IsAPalindrome(palindrome);

            Assert.Equal(expected, actual);
        }
    }
}
