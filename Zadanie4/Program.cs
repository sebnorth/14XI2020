using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj liczbę a");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj liczbę b");
                int b = int.Parse(Console.ReadLine());

                if (b == 0)
                {
                    throw new DivideByZeroException("Proszę podać inną wartość niż zero!!!");
                }

                // a = iloraz * b + reszta

                int iloraz = a / b;
                double ilorazDokladny = 1.0 * a / b;
                int reszta = a % b;

                // int x = 7 / 0;

                Console.WriteLine("{0} = {1} * {2} + {3}", a, iloraz, b, reszta);
                Console.WriteLine("Iloraz dokładny wynosi: {0}", ilorazDokladny);
            }
            catch (DivideByZeroException uchwyt)
            {

                Console.WriteLine(uchwyt.Message);
                // throw;
            }

            catch (Exception uchwyt)
            
            {
                Console.WriteLine(uchwyt.Message);
            
            }

            Console.WriteLine("Program rusza dalej...");
            
            
            Console.ReadKey();
        }
    }
}
