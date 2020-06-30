using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_While
{
    class Program
    {
        static void Main(string[] args)
        {
            var intentos = 0;
            var aleatorio = new Random().Next(1, 10);

            while (aleatorio > 0)
            {
                Console.WriteLine("Ingresa un numero para adivinar el numero secreto: ");
                var numero = Convert.ToInt32(Console.ReadLine());
                intentos += 1;
                if (numero == aleatorio)
                {
                    Console.WriteLine("Adivinaste el numero secreto : {0}, En {1} intentos", numero, intentos);
                }
                else
                {
                    if (numero < aleatorio)
                    {
                        Console.WriteLine("El numero ingresado es inferior al numero secreto");
                    }
                    else
                    {
                        Console.WriteLine("El numero ingresado es mayor al numero secreto");
                    }
                }
                
            }
            aleatorio = 0;
            while (Console.ReadKey().Key != ConsoleKey.Enter) { };
        }

    }
}
