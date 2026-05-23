namespace EquationSolver
{
    public static class EquationUI
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("************************ Welcome to Equation Solver *************************\n");
            Console.WriteLine("This Program solves different basic mathematics equations");
            Console.WriteLine("Menu:\n" +
                              "1. Linear Equation\n" +
                              "2. Simultaneous Equation\n" +
                              "3. Quadratic Equation\n" +
                              "4. Exit program\n\n");
            Console.Write("Please choose the number of type of equation you want to solve... ");
        }

        public static int PromptMenuSelection()
        {
            string input = Console.ReadLine();

            while (!int.TryParse(input, out int selection) || selection < 1 || selection > 4)
            {
                Console.WriteLine("Invalid selection.");
                Console.Write("Please choose a valid option: ");

                input = Console.ReadLine();
            }

            return int.Parse(input);
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

        public static void ShowExitMessage()
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        #region Quadratic Equation UI Methods
        public static void ShowQuadraticIntroduction()
        {
            Console.WriteLine("For Quadratic Equation: ax² + bx + c = 0");
            Console.WriteLine("Please insert the values of a, b, and c");
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
        #endregion

        #region Linear Equation UI Methods
        public static void ShowInvalidLinearA()
        {
            Console.WriteLine("the value of \"a\" cannot be zero");
        }

        public static void ShowLinearIntroduction()
        {
            Console.WriteLine("For Linear Equation: ax + b = 0");
            Console.WriteLine("Please insert the values of a and b");
        }

        public static void ShowEquation(LinearEquation equation)
        {
            Console.WriteLine($"The equation to solve is {equation.A}x + {equation.B} = 0");
        }

        public static void ShowSolutions(LinearEquationSolution solution)
        {
            Console.WriteLine($"x = {solution.X}");
        }
        #endregion

    }
}