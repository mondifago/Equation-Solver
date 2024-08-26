namespace EquationSolver;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("..........................Welcome to Equation Solver..........................");
        Console.WriteLine("This Program solves different basic mathematics equations");
        Console.WriteLine("For Quadratic Equation: ax² + bx + c = 0");
        Console.WriteLine("Please insert the values of a, b, and c");
        
        double a = PromptForValidInput("a= ");
        while (a == 0)
        {
            Console.WriteLine("In a Quadratic Equation, a cannot be zero");
            a = PromptForValidInput("a= ");
        }

        double b = PromptForValidInput("b= ");

        double c = PromptForValidInput("c= ");
        
        Console.WriteLine($"the equation to solve is {a}x² + {b}x + {c} = 0");
        
        //if (b == (y + z) && y * z == a * c)
        double y = (-b + Math.Sqrt(Math.Pow(b, 2) - 4*a*c))/2*a;
        double z = (-b - Math.Sqrt(Math.Pow(b, 2) - 4*a*c))/2*a;
        Console.WriteLine($"solution is (x + {y*-1})(x + {z*-1}) = 0");

        double PromptForValidInput(string promptMessage)
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
} 