using System;

namespace QuadraticEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Програма для розв'язання квадратного рівняння ax^2 + bx + c = 0");
            Console.WriteLine("Автор: Кричкевич Артем Олександрович ");
            Console.WriteLine("Група: Кн21-1\n");

            Console.Write("Введіть коефіцієнт a: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Помилка: a має бути цілим числом.");
                return;
            }

            Console.Write("Введіть коефіцієнт b: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Помилка: b має бути цілим числом.");
                return;
            }

            Console.Write("Введіть коефіцієнт c: ");
            if (!int.TryParse(Console.ReadLine(), out int c))
            {
                Console.WriteLine("Помилка: c має бути цілим числом.");
                return;
            }
            Console.WriteLine($"\nКвадратне рівняння: {a}x^2 + {b}x + {c} = 0");
            SolveQuadraticEquation(a, b, c);
        }

        static void SolveQuadraticEquation(int a, int b, int c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("Рівняння не має дійсних розв'язків.");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * (double)a);
                Console.WriteLine($"Рівняння має один дійсний розв'язок: x = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Рівняння має два дійсних розв'язки: x1 = {x1}, x2 = {x2}");
            }
        }
    }
}
