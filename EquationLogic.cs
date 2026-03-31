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
            return Math.Pow(b, 2) - 4 * a * c;
        }

        public static double CalculateX1(double a, double b, double c)
        {
            double squareRootOfDiscriminant = Math.Sqrt(Discriminant(a, b, c));
            return (-b + squareRootOfDiscriminant) / (2 * a);
        }

        public static double CalculateX2(double a, double b, double c)
        {
            double squareRootOfDiscriminant = Math.Sqrt(Discriminant(a, b, c));
            return (-b - squareRootOfDiscriminant) / (2 * a);
        }
    }
}