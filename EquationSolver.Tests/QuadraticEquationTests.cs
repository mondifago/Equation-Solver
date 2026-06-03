using System;
using System.Collections.Generic;
using System.Text;

namespace EquationSolver.Tests
{
    public class QuadraticEquationTests
    {
        [Fact]
        public void Discriminant_ReturnsPositive_WhenTwoDistinctRoots()
        {
            // x² - 5x + 6 = 0  →  discriminant = 1
            var equation = new QuadraticEquation { A = 1, B = -5, C = 6 };
            Assert.True(EquationLogic.Discriminant(equation) > 0);
        }

        [Fact]
        public void Discriminant_ReturnsZero_WhenTwoEqualRoots()
        {
            // x² - 2x + 1 = 0  →  discriminant = 0
            var equation = new QuadraticEquation { A = 1, B = -2, C = 1 };
            Assert.Equal(0, EquationLogic.Discriminant(equation));
        }

        [Fact]
        public void Discriminant_ReturnsNegative_WhenNoRealRoots()
        {
            // x² + x + 1 = 0  →  discriminant = -3
            var equation = new QuadraticEquation { A = 1, B = 1, C = 1 };
            Assert.True(EquationLogic.Discriminant(equation) < 0);
        }

        [Fact]
        public void SolveQuadraticEquation_ReturnsTwoDistinctRoots()
        {
            // x² - 5x + 6 = 0  →  x = 3 or x = 2
            var equation = new QuadraticEquation { A = 1, B = -5, C = 6 };
            var solution = EquationLogic.SolveQuadraticEquation(equation);

            Assert.Equal(3, solution.X1, 5);
            Assert.Equal(2, solution.X2, 5);
        }

        [Fact]
        public void SolveQuadraticEquation_ReturnsTwoEqualRoots_WhenDiscriminantIsZero()
        {
            // x² - 2x + 1 = 0  →  x = 1 
            var equation = new QuadraticEquation { A = 1, B = -2, C = 1 };
            var solution = EquationLogic.SolveQuadraticEquation(equation);

            Assert.Equal(solution.X1, solution.X2);
        }

        [Fact]
        public void SolveQuadraticEquation_WhenAIsZero_FallsBackToLinearCorrectly()
        {
            // 0x² + 2x + 4 = 0  →  treated as linear: 2x + 4 = 0  →  x = -2
            var quadratic = new QuadraticEquation { A = 0, B = 2, C = 4 };
            var linear = new LinearEquation { A = quadratic.B, B = quadratic.C };
            var solution = EquationLogic.SolveLinearEquation(linear);

            Assert.Equal(-2, solution.X);
        }
    }
}
