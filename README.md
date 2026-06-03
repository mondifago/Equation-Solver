# Equation Solver

A C# console application that solves linear, simultaneous, and quadratic equations with clean step-by-step output. Built as a learning tool for secondary school mathematics.

---

## Features

- **Linear equations** — solves `ax + b = 0`, with validation that `a ≠ 0`
- **Simultaneous equations** — solves two-variable systems using Cramer's rule; detects parallel or identical lines
- **Quadratic equations** — solves `ax² + bx + c = 0` via the quadratic formula; detects no-real-solution cases and gracefully falls back to linear solving when `a = 0`
- Input validation on all coefficients with clear error messages
- Menu-driven loop — solve multiple equations of the same type without restarting

---

## Project Structure

```
EquationSolverSolution/
├── EquationSolver.sln
├── Equation-Solver/
│   ├── EquationSolver.csproj
│   ├── EquationLogic.cs          # All computation — discriminants, solvers, validation
│   ├── EquationUI.cs             # All console I/O — prompts, display, formatting
│   ├── EquationConstants.cs      # Shared numeric constants
│   ├── Program.cs                # Entry point and menu loop
│   └── Class Models/
│       ├── LinearEquation.cs
│       ├── LinearEquationSolution.cs
│       ├── QuadraticEquation.cs
│       ├── QuadraticEquationSolution.cs
│       ├── SimultaneousEquation.cs
│       └── SimultaneousEquationSolution.cs
└── EquationSolver.Tests/
    ├── EquationSolver.Tests.csproj
    ├── LinearEquationTests.cs
    ├── QuadraticEquationTests.cs
    ├── SimultaneousEquationTests.cs
    └── ValidationTests.cs
```

### Architecture

A strict separation of concerns is maintained throughout:

- **`EquationLogic.cs`** — pure computation only. No console calls, no formatting. All solving methods, discriminant calculations, and input validation live here.
- **`EquationUI.cs`** — display and interaction only. No maths logic. All `Console.Write`, `Console.ReadLine`, and output formatting live here.
- **`Program.cs`** — orchestrates the two: reads user choices, calls logic, passes results to UI.

---

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

### Run the app

```bash
git clone https://github.com/mondifago/Equation-Solver.git
cd Equation-Solver/EquationSolverSolution
dotnet run --project Equation-Solver
```

### Run the tests

```bash
dotnet test
```

---

## Equation Types

### Linear — `ax + b = 0`

Solves for `x` using `x = -b / a`. Requires `a ≠ 0`.

**Example:** `2x + 4 = 0` → `x = -2`

---

### Simultaneous — `a₁x + b₁y = c₁` and `a₂x + b₂y = c₂`

Solves using Cramer's rule on the 2×2 coefficient matrix. Detects zero determinant (parallel or identical lines) and reports no unique solution.

**Example:** `x + y = 3` and `x - y = 1` → `x = 2, y = 1`

---

### Quadratic — `ax² + bx + c = 0`

Solves using the quadratic formula. Three cases handled:

| Discriminant | Result |
|---|---|
| `> 0` | Two distinct real roots |
| `= 0` | One repeated real root |
| `< 0` | No real solutions |

When `a = 0`, the equation is treated as linear and solved accordingly.

**Example:** `x² - 5x + 6 = 0` → `x = 3 or x = 2`

---

## Tests

The test suite uses [xUnit](https://xunit.net/) and covers:

| Test file | What it covers |
|---|---|
| `LinearEquationTests.cs` | Basic and parameterised cases for `SolveLinearEquation` |
| `QuadraticEquationTests.cs` | Discriminant sign, two roots, equal roots, `a = 0` fallback |
| `SimultaneousEquationTests.cs` | Correct `x` and `y`, zero determinant, unique solution detection |
| `ValidationTests.cs` | Valid and invalid inputs for `IsValidNumber` |

---

## Roadmap

This console app is the foundation for **Mathline** — a planned Blazor MAUI Hybrid educational app targeting secondary school students, featuring:

- Custom maths keypad for equation input
- Live graph rendering with solution points marked (SkiaSharp)
- Camera/OCR scanning of handwritten equations (mobile)
- Multi-line input with auto-detection of simultaneous equations

---

## License

MIT
