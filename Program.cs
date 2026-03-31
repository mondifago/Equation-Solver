namespace EquationSolver;

class Program
{
    static void Main(string[] args)
    {
        // Introduction
        Console.WriteLine("..........................Welcome to Equation Solver..........................");
        Console.WriteLine("This Program solves different basic mathematics equations");
        Console.WriteLine("For Quadratic Equation: ax² + bx + c = 0");
        Console.WriteLine("Please insert the values of a, b, and c");

        // Input
        double a = PromptForValidInput("a= ");

        while (a == 0)
        {
            Console.WriteLine("In a Quadratic Equation, a cannot be zero");
            a = PromptForValidInput("a= ");
        }

        double b = PromptForValidInput("b= ");
        double c = PromptForValidInput("c= ");

        // Display equation
        Console.WriteLine($"The equation to solve is {a}x² + {b}x + {c} = 0");

        // Solve
        if (DomainLogic.Discriminant(a, b, c) < 0)
        {
            Console.WriteLine("No real solutions.");
        }
        else
        {
            double sqrtD = Math.Sqrt(DomainLogic.Discriminant(a, b, c));

            double x1 = (-b + sqrtD) / (2 * a);
            double x2 = (-b - sqrtD) / (2 * a);

            // Main Answer Output
            Console.WriteLine($"x = {x1} or x = {x2}");
            Console.WriteLine($"Factorised form: (x - {x1})(x - {x2}) = 0");
        }

        // Exit pause
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static double PromptForValidInput(string promptMessage)
    {
        Console.Write(promptMessage);
        string input = Console.ReadLine();

        while (!DomainLogic.IsValidNumber(input))
        {
            Console.WriteLine("\nInvalid input. Please enter a valid number.");
            Console.Write(promptMessage);
            input = Console.ReadLine();
        }

        return double.Parse(input);
    }
}