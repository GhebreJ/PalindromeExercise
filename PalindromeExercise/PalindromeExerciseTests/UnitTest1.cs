using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("aadaa", true)]
        [InlineData("pies", false)]
        [InlineData("00310", false)]
        public void IsAPalinDromeTest(string word, bool expected)
        {
            //Act
            var ws = new WordSmith();

            var actual = ws.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
