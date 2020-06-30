using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCrear
{

    partial class Program
    {

        static void Main(string[] args)
        {
            try
            {
                var resultado1 = int.Parse("Leo");
            }
            catch (Exception)
            {

                Console.WriteLine("La conversion fallo");
            }

            int numero;
            var resultado = int.TryParse("Leo", out numero);
            if (resultado)
                Console.WriteLine(resultado);
            else
                Console.WriteLine("La conversion fallo");
        }

        public void UseParams()
        {
            var calculadora = new Calculator();
            Console.WriteLine(calculadora.Add(5, 7));
            Console.WriteLine(calculadora.Add(5, 7, 5, 6));
            Console.WriteLine(calculadora.Add(5, 7, 6, 3, 4));
            Console.WriteLine(calculadora.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
        }

        public void UsePoints()
        {
            try
            {
                var point = new Point(20, 40);
                point.Move(new Point(100, 200));
                Console.WriteLine("El punto esta en ({0}, {1})", point.X, point.Y);
                //while(Console.ReadKey().Key != ConsoleKey.Enter) { }

                point.Move(50, 100);
                Console.WriteLine("El punto esta en ({0}, {1})", point.X, point.Y);
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            catch (Exception)
            {
                Console.WriteLine("La aplicacion fallo...");

            }
        }
    }
}
