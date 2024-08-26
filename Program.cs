namespace EquationSolver;

class Program
{
    static void Main(string[] args)
    {
        double a;
        double b;
        double c;
        double y;
        double z; 
        Console.WriteLine("..........................Welcome to Equation Solver..........................");
        Console.WriteLine("This Program solves different basic mathematics equations");
        Console.WriteLine("For Quadratic Equation: ax² + bx + c = 0");
        Console.WriteLine("Please insert the values of a, b, and c");
        Console.Write("a = ");
        a = Convert.ToDouble(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("In a Quadratic Equation, a cannot be zero");
        }
        Console.Write("b = ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c = ");
        c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"the equation to solve is {a}x² + {b}x + {c} = 0");
        
        //if (b == (y + z) && y * z == a * c)
        y = (-b + Math.Sqrt(Math.Pow(b, 2) - 4*a*c))/2*a;
        z = (-b - Math.Sqrt(Math.Pow(b, 2) - 4*a*c))/2*a;
        Console.WriteLine($"solution is (x + {y*-1})(x + {z*-1}) = 0");

        double validateInput()
        {
            
        }
        
            
                
        

    }
} 