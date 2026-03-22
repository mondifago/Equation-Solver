namespace EquationSolver;

class Program
{
    static void Main(string[] args)
    {
        //Introduction
        Console.WriteLine("..........................Welcome to Equation Solver..........................");
        Console.WriteLine("This Program solves different basic mathematics equations");
        Console.WriteLine("For Quadratic Equation: ax² + bx + c = 0");
        Console.WriteLine("Please insert the values of a, b, and c");

        //Input
        double a = PromptForValidInput("a= ");
        while (a == 0)
        {
            Console.WriteLine("In a Quadratic Equation, a cannot be zero");
            a = PromptForValidInput("a= ");
        }

        double b = PromptForValidInput("b= ");
        double c = PromptForValidInput("c= ");

        Console.WriteLine($"The equation to solve is {a}x² + {b}x + {c} = 0");

        //Calculate discriminant
        double discriminant = Math.Pow(b, 2) - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine("No real solutions.");
        }
        else
        {
            double sqrtD = Math.Sqrt(discriminant);

            double x1 = (-b + sqrtD) / (2 * a);
            double x2 = (-b - sqrtD) / (2 * a);

            //Main Answer Output
            Console.WriteLine($"x = {x1} or x = {x2}");
            Console.WriteLine($"Factorised form: (x - {x1})(x - {x2}) = 0");
        }

        //Exit pause
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    //input validator
    static double PromptForValidInput(string promptMessage)
    {
        Console.Write(promptMessage);
        string input = Console.ReadLine();
        double validNumber;

        while (!double.TryParse(input, out validNumber) || string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("\nInvalid input. Please enter a valid number.");
            Console.Write(promptMessage);
            input = Console.ReadLine();
        }

        return validNumber;
    }
}