using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosClaseCronometro
{

    class Program
    {
        static void Main(string[] args)
        {
            var tiempoInicio = new TimeSpan(1,0,0);
            var tiempoFin = new TimeSpan(4,30,0);

            var cronometro = new Cronometro(tiempoFin, tiempoInicio);
            var tiempototal = cronometro.CalcularIntervalo(tiempoFin, tiempoInicio);

            Console.WriteLine(tiempototal);
            while(Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
