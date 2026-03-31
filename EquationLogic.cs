using Microsoft.VisualBasic;

namespace EquationSolver
{
    public class EquationLogic
    {
        public static bool IsValidNumber(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && double.TryParse(input, out _);
        }

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

            solution.X2 = (-equation.B - solution.SquareRootOfDiscriminant)  / (EquationConstants.TWO * equation.A);

            return solution;
        }
    }
}