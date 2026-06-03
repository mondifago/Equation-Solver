using EquationSolver.Class_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EquationSolver.Tests
{
    public class SimultaneousEquationTests
    {
        [Fact]
        public void SolveSimultaneousEquation_ReturnsCorrectXAndY()
        {
            // x + y = 3 and x - y = 1  →  x = 2, y = 1
            var equation = new SimultaneousEquation
            {
                A1 = 1,
                B1 = 1,
                C1 = 3,
                A2 = 1,
                B2 = -1,
                C2 = 1
            };

            var solution = EquationLogic.SolveSimultaneousEquation(equation);

            Assert.Equal(2, solution.X, 5);
            Assert.Equal(1, solution.Y, 5);
        }

        [Fact]
        public void Determinant_ReturnsZero_WhenEquationsAreIdentical()
        {
            var equation = new SimultaneousEquation
            {
                A1 = 2,
                B1 = 3,
                C1 = 5,
                A2 = 2,
                B2 = 3,
                C2 = 5
            };

            Assert.Equal(0, EquationLogic.Determinant(equation));
        }

        [Fact]
        public void HasUniqueSolution_ReturnsFalse_WhenLinesAreParallel()
        {
            // 2x + 4y = 6  and  1x + 2y = 5  →  parallel
            var equation = new SimultaneousEquation
            {
                A1 = 2,
                B1 = 4,
                C1 = 6,
                A2 = 1,
                B2 = 2,
                C2 = 5
            };

            Assert.False(EquationLogic.HasUniqueSolution(equation));
        }

        [Fact]
        public void HasUniqueSolution_ReturnsTrue_WhenSolutionExists()
        {
            var equation = new SimultaneousEquation
            {
                A1 = 1,
                B1 = 1,
                C1 = 3,
                A2 = 1,
                B2 = -1,
                C2 = 1
            };

            Assert.True(EquationLogic.HasUniqueSolution(equation));
        }
    }
}
