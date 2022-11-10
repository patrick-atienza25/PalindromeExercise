using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kayak", true)]
        [InlineData("peep", true)]
        [InlineData("hello world", false)]
        [InlineData("pug", false)]
        [InlineData("runner", false)]
        public void Test1(string word, bool expected)
        {
            //arange
            WordSmith wordSmith = new WordSmith();

            //act
            var actual = wordSmith.IsAPalindrome(word);

            //assert
            Assert.Equal(actual, expected);
        }
    }
}
