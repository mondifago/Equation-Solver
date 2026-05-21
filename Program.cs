namespace EquationSolver;

class Program
{
    static void Main(string[] args)
    {
        EquationUI.ShowMenu();

        int selection = EquationUI.PromptMenuSelection();

        switch (selection)
        {
            case 1:
                Console.WriteLine("Linear Equation selected");
                break;

            case 2:
                Console.WriteLine("Simultaneous Equation selected");
                break;

            case 3:

                QuadraticEquation equation = new QuadraticEquation();
                QuadraticEquationSolution solution = new QuadraticEquationSolution();

                EquationUI.ShowQuadraticIntroduction();

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

                break;

            case 4:
                return;
        }

        EquationUI.ShowExitMessage();
    }
}