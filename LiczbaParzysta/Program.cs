using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbaParzysta
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj liczbę: ");
            // a = Convert.ToInt32(Console.ReadLine());
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Liczba {0} jest parzysta", a);
            }
            else 
            {
                Console.WriteLine("Liczba {0} jest nieparzysta", a);
            }

            Console.ReadKey();
        }
    }
}
