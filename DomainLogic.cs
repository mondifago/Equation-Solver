namespace EquationSolver
{
    public class DomainLogic
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
    }
}