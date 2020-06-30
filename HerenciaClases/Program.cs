using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaClases
{

    class Program
    {
        static void Main(string[] args)
        {
            var text = new Texto();
            text.Alto = 200;
            text.NombreTexto = "Times new Roman";
            text.Ancho = 500;
            text.Copiar();
            text.Duplicar();
            Console.WriteLine("Alto: {0}, Ancho: {1}, Texto: {2}", text.Alto,  text.Ancho, text.NombreTexto);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }
    }
}
