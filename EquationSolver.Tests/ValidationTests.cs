using System;
using System.Collections.Generic;
using System.Text;

namespace EquationSolver.Tests
{
    public class ValidationTests
    {
        [Theory]
        [InlineData("3", true)]
        [InlineData("3.14", true)]
        [InlineData("-5", true)]
        [InlineData("0", true)]
        [InlineData("", false)]
        [InlineData("   ", false)]
        [InlineData("abc", false)]
        [InlineData("12abc", false)]
        [InlineData(null, false)]
        public void IsValidNumber_ReturnsExpected(string input, bool expected)
        {
            Assert.Equal(expected, EquationLogic.IsValidNumber(input));
        }
    }
}
