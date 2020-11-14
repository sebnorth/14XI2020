using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokPrzestepny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok: ");
            int rok = int.Parse(Console.ReadLine());

            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
            {
                Console.WriteLine("Rok {0} jest przestępny", rok);
            }
            else {

                Console.WriteLine("Rok {0} NIE jest przestępny", rok);
            }

            Console.ReadKey();
        }
    }
}
