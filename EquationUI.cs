namespace EquationSolver
{
    public static class EquationUI
    {
        public static void ShowIntroduction()
        {
            Console.WriteLine("..........................Welcome to Equation Solver..........................");
            Console.WriteLine("This Program solves different basic mathematics equations");
            Console.WriteLine("For Quadratic Equation: ax² + bx + c = 0");
            Console.WriteLine("Please insert the values of a, b, and c");
        }

        public static double PromptForValidInput(string promptMessage)
        {
            Console.Write(promptMessage);
            string input = Console.ReadLine();

            while (!EquationLogic.IsValidNumber(input))
            {
                Console.WriteLine("\nInvalid input. Please enter a valid number.");
                Console.Write(promptMessage);
                input = Console.ReadLine();
            }

            return double.Parse(input);
        }

        public static void ShowInvalidQuadraticA()
        {
            Console.WriteLine("In a Quadratic Equation, a cannot be zero");
        }

        public static void ShowEquation(QuadraticEquation equation)
        {
            Console.WriteLine($"The equation to solve is {equation.A}x² + {equation.B}x + {equation.C} = 0");
        }

        public static void ShowNoRealSolutions()
        {
            Console.WriteLine("No real solutions.");
        }

        public static void ShowSolutions(QuadraticEquationSolution solution)
        {
            Console.WriteLine($"x = {solution.X1} or x = {solution.X2}");
            Console.WriteLine($"Factorised form: (x - {solution.X1})(x - {solution.X2}) = 0");
        }

        public static void ShowExitMessage()
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}