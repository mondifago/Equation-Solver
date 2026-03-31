namespace EquationSolver;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        double a;
        double b;
        double c;
        double x1;
        double x2;

        // Introduction
        EquationUI.ShowIntroduction();

        // Input
        a = EquationUI.PromptForValidInput("a= ");

        while (a == 0)
        {
            EquationUI.ShowInvalidQuadraticA();
            a = EquationUI.PromptForValidInput("a= ");
        }

        b = EquationUI.PromptForValidInput("b= ");
        c = EquationUI.PromptForValidInput("c= ");

        // Display equation
        EquationUI.ShowEquation(a, b, c);

        // Solve
        if (DomainLogic.Discriminant(a, b, c) < 0)
        {
            EquationUI.ShowNoRealSolutions();
        }
        else
        {
            x1 = DomainLogic.CalculateX1(a, b, c);
            x2 = DomainLogic.CalculateX2(a, b, c);

            EquationUI.ShowSolutions(x1, x2);
        }

        // Exit pause
        EquationUI.ShowExitMessage();
    }
}