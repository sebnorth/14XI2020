using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZnakLiczby
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            int a = int.Parse(Console.ReadLine());

            if (a > 0) 
            {
                Console.WriteLine("Podana została liczba dodatnia.");
            }
            else
            {

                if (a < 0) {

                    Console.WriteLine("Podana została liczba ujemna.");

                }
                else
                {

                    Console.WriteLine("Podana została liczba zero.");
                
                }

            
            }

            Console.ReadKey();
        }
    }
}
