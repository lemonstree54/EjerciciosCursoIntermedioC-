using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClasesCronometroII
{


    class Program
    {
        static void Main(string[] args)
        {
            var tiempoinicial = new TimeSpan(10, 10, 0);
            var tiempofinal = new TimeSpan(10, 25, 0);

            var cronometro = new Cronometro(tiempofinal, tiempoinicial);
            var tiempoTotal = cronometro.CalcularCronometro(tiempofinal, tiempoinicial);

            Console.WriteLine(tiempoTotal);
            while(Console.ReadKey().Key != ConsoleKey.Enter){ }

        }
    }
}
