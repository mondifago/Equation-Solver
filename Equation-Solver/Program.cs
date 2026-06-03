using EquationSolver.Class_Models;

namespace EquationSolver;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            EquationUI.ShowMenu();
            int selection = EquationUI.PromptMenuSelection();

            switch (selection)
            {
                case 1:
                    {
                        Console.Clear();
                        EquationUI.ShowLinearIntroduction();

                        bool continueLinear = true;
                        bool firstEquation = true;

                        while (continueLinear)
                        {
                            if (!firstEquation) EquationUI.ShowEquationSeparator();

                            LinearEquation equation = new LinearEquation();

                            equation.A = EquationUI.PromptForValidInput("a= ");

                            while (equation.A == 0)
                            {
                                EquationUI.ShowInvalidLinearA();
                                equation.A = EquationUI.PromptForValidInput("a= ");
                            }
                            equation.B = EquationUI.PromptForValidInput("b= ");

                            EquationUI.ShowEquation(equation);
                            LinearEquationSolution solution = EquationLogic.SolveLinearEquation(equation);
                            EquationUI.ShowSolutions(solution);

                            continueLinear = EquationUI.PromptContinueOrMenu("linear equation");
                            firstEquation = false;
                        }
                        break;
                    }

                case 2:
                    {
                        Console.Clear();
                        EquationUI.ShowSimultaneousIntroduction();

                        bool continueSimultaneous = true;
                        bool firstEquation = true;

                        while (continueSimultaneous)
                        {
                            if (!firstEquation) EquationUI.ShowEquationSeparator();

                            SimultaneousEquation equation = new SimultaneousEquation();

                            EquationUI.ShowEquationOne();
                            equation.A1 = EquationUI.PromptForValidInput("a1= ");
                            equation.B1 = EquationUI.PromptForValidInput("b1= ");
                            equation.C1 = EquationUI.PromptForValidInput("c1= ");

                            EquationUI.ShowEquationTwo();
                            equation.A2 = EquationUI.PromptForValidInput("a2= ");
                            equation.B2 = EquationUI.PromptForValidInput("b2= ");
                            equation.C2 = EquationUI.PromptForValidInput("c2= ");

                            EquationUI.ShowEquation(equation);

                            if (!EquationLogic.HasUniqueSolution(equation))
                            {
                                EquationUI.ShowNoUniqueSolution();
                            }
                            else
                            {
                                SimultaneousEquationSolution solution = EquationLogic.SolveSimultaneousEquation(equation);
                                EquationUI.ShowSolutions(solution);
                            }

                            continueSimultaneous = EquationUI.PromptContinueOrMenu("simultaneous equation");
                            firstEquation = false;
                        }

                        break;
                    }

                case 3:
                    {
                        Console.Clear();
                        EquationUI.ShowQuadraticIntroduction();

                        bool continueQuadratic = true;
                        bool firstEquation = true;

                        while (continueQuadratic)
                        {
                            if (!firstEquation) EquationUI.ShowEquationSeparator();

                            QuadraticEquation equation = new QuadraticEquation();

                            equation.A = EquationUI.PromptForValidInput("a= ");
                            equation.B = EquationUI.PromptForValidInput("b= ");
                            equation.C = EquationUI.PromptForValidInput("c= ");

                            if (equation.A == 0)
                            {
                                EquationUI.ShowRevertToLinearEquationMessage();

                                LinearEquation linearEquation = new LinearEquation();
                                linearEquation.A = equation.B;
                                linearEquation.B = equation.C;

                                EquationUI.ShowEquation(linearEquation);
                                LinearEquationSolution linearSolution = EquationLogic.SolveLinearEquation(linearEquation);
                                EquationUI.ShowSolutions(linearSolution);
                            }
                            else
                            {
                                EquationUI.ShowEquation(equation);

                                if (EquationLogic.Discriminant(equation) < 0)
                                {
                                    EquationUI.ShowNoRealSolutions();
                                }
                                else
                                {
                                    QuadraticEquationSolution solution = EquationLogic.SolveQuadraticEquation(equation);
                                    EquationUI.ShowSolutions(solution);
                                }
                            }

                            continueQuadratic = EquationUI.PromptContinueOrMenu("quadratic equation");
                            firstEquation = false;
                        }
                        break;
                    }

                case 4:
                    running = false;
                    break;
            }
        }

    }
}