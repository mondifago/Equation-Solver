namespace EquationSolver;

class Program
{
    static void Main(string[] args)
    {
        // Introduction
        EquationUI.ShowIntroduction();

        // Input
        double a = EquationUI.PromptForValidInput("a= ");

        while (a == 0)
        {
            EquationUI.ShowInvalidQuadraticA();
            a = EquationUI.PromptForValidInput("a= ");
        }

        double b = EquationUI.PromptForValidInput("b= ");
        double c = EquationUI.PromptForValidInput("c= ");

        // Display equation
        EquationUI.ShowEquation(a, b, c);

        // Solve
        if (DomainLogic.Discriminant(a, b, c) < 0)
        {
            EquationUI.ShowNoRealSolutions();
        }
        else
        {
            double sqrtD = Math.Sqrt(DomainLogic.Discriminant(a, b, c));

            double x1 = (-b + sqrtD) / (2 * a);
            double x2 = (-b - sqrtD) / (2 * a);

            EquationUI.ShowSolutions(x1, x2);
        }

        // Exit pause
        EquationUI.ShowExitMessage();
    }
}