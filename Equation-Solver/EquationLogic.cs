
using EquationSolver.Class_Models;

namespace EquationSolver
{
    public class EquationLogic
    {
        #region Linear Equation Logic Methods
        public static LinearEquationSolution SolveLinearEquation(LinearEquation equation)
        {
            LinearEquationSolution solution = new LinearEquationSolution();

            solution.X = -equation.B / equation.A;

            return solution;
        }
        #endregion

        #region Simultaneous Equation Logic Methods
        public static double Determinant(SimultaneousEquation equation)
        {
            return equation.A1 * equation.B2 - equation.A2 * equation.B1;
        }

        public static SimultaneousEquationSolution SolveSimultaneousEquation(SimultaneousEquation equation)
        {
            SimultaneousEquationSolution solution = new SimultaneousEquationSolution();
            double determinant = Determinant(equation);

            solution.X = (equation.C1 * equation.B2 - equation.C2 * equation.B1) / determinant;
            solution.Y = (equation.A1 * equation.C2 - equation.A2 * equation.C1) / determinant;

            return solution;
        }

        public static bool HasUniqueSolution(SimultaneousEquation equation)
        {
            return Determinant(equation) != 0;
        }
        #endregion

        #region Quadratic Equation Logic Methods
        public static double Discriminant(QuadraticEquation equation)
        {
            return Math.Pow(equation.B, EquationConstants.TWO) - EquationConstants.FOUR * equation.A * equation.C;
        }

        public static double CalculateSquareRootOfDiscriminant(QuadraticEquation equation)
        {
            return Math.Sqrt(Discriminant(equation));
        }

        public static QuadraticEquationSolution SolveQuadraticEquation(QuadraticEquation equation)
        {
            QuadraticEquationSolution solution = new QuadraticEquationSolution();

            solution.Discriminant = Discriminant(equation);
            solution.SquareRootOfDiscriminant = CalculateSquareRootOfDiscriminant(equation);

            solution.X1 = (-equation.B + solution.SquareRootOfDiscriminant) / (EquationConstants.TWO * equation.A);

            solution.X2 = (-equation.B - solution.SquareRootOfDiscriminant) / (EquationConstants.TWO * equation.A);

            return solution;
        }
        #endregion
      
        public static bool IsValidNumber(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && double.TryParse(input, out _);
        }
    }
}