using System;
using gradeAPI.Models;
using Xunit;

namespace gradeTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(90, "A")]
        public void Test1(int input, string expected)
        {
            var sut = new GradeLogic();
            var result = sut.Calculate(input);
            Assert.Equal(expected, result);
        }
    }
}
