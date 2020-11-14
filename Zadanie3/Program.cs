using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę");
            int liczba1 = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Podaj drugą liczbę");
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            int suma = liczba1 + liczba2;

            Console.WriteLine("Suma liczb {0} oraz {1} wynosi: {2}", liczba1, liczba2, suma);
            Console.ReadKey();
        }
    }
}
