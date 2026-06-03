using System;
using System.Collections.Generic;
using System.Text;

namespace EquationSolver.Tests
{
    public class LinearEquationTests
    {
        [Fact]
        public void SolveLinearEquation_BasicCase_ReturnsCorrectX()
        {
            var equation = new LinearEquation { A = 2, B = 4 };
            var solution = EquationLogic.SolveLinearEquation(equation);
            Assert.Equal(-2, solution.X);
        }

        [Theory]
        [InlineData(3, -9, 3)]
        [InlineData(1, 0, 0)]
        [InlineData(5, 1, -0.2)]
        public void SolveLinearEquation_VariousCases_ReturnsCorrectX(double a, double b, double expected)
        {
            var equation = new LinearEquation { A = a, B = b };
            var solution = EquationLogic.SolveLinearEquation(equation);
            Assert.Equal(expected, solution.X, 5);
        }
    }
}
