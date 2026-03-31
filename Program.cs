namespace EquationSolver;

class Program
{
    static void Main(string[] args)
    {
        QuadraticEquation equation = new QuadraticEquation();
        QuadraticEquationSolution solution = new QuadraticEquationSolution();

        EquationUI.ShowIntroduction();

        equation.A = EquationUI.PromptForValidInput("a= ");

        while (equation.A == 0)
        {
            EquationUI.ShowInvalidQuadraticA();
            equation.A = EquationUI.PromptForValidInput("a= ");
        }

        equation.B = EquationUI.PromptForValidInput("b= ");
        equation.C = EquationUI.PromptForValidInput("c= ");

        EquationUI.ShowEquation(equation);

        if (EquationLogic.Discriminant(equation) < 0)
        {
            EquationUI.ShowNoRealSolutions();
        }
        else
        {
            solution = EquationLogic.SolveQuadraticEquation(equation);

            EquationUI.ShowSolutions(solution);
        }

        EquationUI.ShowExitMessage();
    }
}