using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensayo
{

    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("La conversion fallo.");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { };
            }
            var numero = 0;
            var resultado = int.TryParse("abc", out numero);
            if(resultado)
                Console.WriteLine(numero);
            else
                Console.WriteLine("La conversion fallo.");
            while(Console.ReadKey().Key != ConsoleKey.Enter) { };
        }

        static void UsarParametros()
        {
            var calculadora = new Calculadora();
            Console.WriteLine(calculadora.Sumar(1, 2));
            Console.WriteLine(calculadora.Sumar(10, 20));
            Console.WriteLine(calculadora.Sumar(100, 200));
            Console.WriteLine(calculadora.Sumar(1000, 2000));
            while (Console.ReadKey().Key != ConsoleKey.Enter) { };
        }

        static void UsarPuntos()
        {
            try
            {
                var punto = new Punto(20, 30);
                punto.Move(null);
                Console.WriteLine("El punto es: ({0}, {1})", punto.X, punto.Y);

                punto.Move(200, 100);
                Console.WriteLine("El punto es: ({0}, {1})", punto.X, punto.Y);
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error no esperado.");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { };
            }
        }
    }
}
