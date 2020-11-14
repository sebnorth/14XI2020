using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program obliczający pierwiastki równania kwadratowego
            // a*x^2 + b* x + c = 0
            // Delta = b*b - 4*a*c

            Console.WriteLine("Podaj a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj c: ");
            int c = int.Parse(Console.ReadLine());

            // Math.Sqrt(x) - pierwiastek kwadratowy z x

            // dodatkowo obsługa przypadku kiedy a = 0, użyć try-catch

        }
    }
}
