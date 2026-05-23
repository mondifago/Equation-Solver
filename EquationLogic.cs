
namespace EquationSolver
{
    public class EquationLogic
    {
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
      
        #region Linear Equation Logic Methods
        public static LinearEquationSolution SolveLinearEquation(LinearEquation equation)
        {
            LinearEquationSolution solution = new LinearEquationSolution();

            solution.X = -equation.B / equation.A;

            return solution;
        }
        #endregion

        public static bool IsValidNumber(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && double.TryParse(input, out _);
        }
    }
}