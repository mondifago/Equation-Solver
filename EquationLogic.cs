using Microsoft.VisualBasic;

namespace EquationSolver
{
    public class EquationLogic
    {
        // Input validator
        public static bool IsValidNumber(string input)
        {
            return !string.IsNullOrWhiteSpace(input) && double.TryParse(input, out _);
        }

        // Calculate discriminant
        public static double Discriminant(double a, double b, double c)
        {
            return Math.Pow(b, EquationConstants.TWO) - EquationConstants.FOUR * a * c;
        }

        public static double CalculateSquareRootOfDiscriminant(double a, double b, double c)
        {
            return Math.Sqrt(Discriminant(a, b, c));
        }

        public static double CalculateX1(double a, double b, double c)
        {
            double squareRootOfDiscriminant = CalculateSquareRootOfDiscriminant(a, b, c);

            return (-b + squareRootOfDiscriminant) / (EquationConstants.TWO * a);
        }

        public static double CalculateX2(double a, double b, double c)
        {
            double squareRootOfDiscriminant = CalculateSquareRootOfDiscriminant(a, b, c);

            return (-b - squareRootOfDiscriminant) / (EquationConstants.TWO * a);
        }
    }
}