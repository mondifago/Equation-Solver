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
                {
                    LinearEquation linearEquation = new LinearEquation();
                    LinearEquationSolution linearSolution = new LinearEquationSolution();

                    EquationUI.ShowLinearIntroduction();

                    linearEquation.A = EquationUI.PromptForValidInput("a= ");

                    while (linearEquation.A == 0)
                    {
                        EquationUI.ShowInvalidLinearA();

                        linearEquation.A = EquationUI.PromptForValidInput("a= ");
                    }

                    linearEquation.B = EquationUI.PromptForValidInput("b= ");

                    EquationUI.ShowEquation(linearEquation);

                    linearSolution = EquationLogic.SolveLinearEquation(linearEquation);

                    EquationUI.ShowSolutions(linearSolution);

                    break;
                }

            case 2:
                Console.WriteLine("Simultaneous Equation selected");
                break;

            case 3:
                {
                    QuadraticEquation equation = new QuadraticEquation();
                    QuadraticEquationSolution solution = new QuadraticEquationSolution();

                    EquationUI.ShowQuadraticIntroduction();

                    equation.A = EquationUI.PromptForValidInput("a= ");
                    equation.B = EquationUI.PromptForValidInput("b= ");
                    equation.C = EquationUI.PromptForValidInput("c= ");

                    if (equation.A == 0)
                    {
                        Console.WriteLine("\nSince a = 0, the equation becomes a Linear Equation.\n");

                        LinearEquation linearEquation = new LinearEquation();

                        linearEquation.A = equation.B;
                        linearEquation.B = equation.C;

                        EquationUI.ShowEquation(linearEquation);

                        LinearEquationSolution linearSolution =
                            EquationLogic.SolveLinearEquation(linearEquation);

                        EquationUI.ShowSolutions(linearSolution);

                        break;
                    }

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
                }

                case 4:
                    return;
        }

        EquationUI.ShowExitMessage();
    }
}