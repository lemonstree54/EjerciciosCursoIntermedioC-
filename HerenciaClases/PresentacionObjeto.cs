using System;

namespace HerenciaClases
{
    public class PresentacionObjeto
    {
        public int Ancho { get; set; }
        public int Alto { get; set; }

        public void Copiar()
        {
            Console.WriteLine("Los datos se han copiado");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        public void Duplicar()
        {
            Console.WriteLine("Los datos se han duplicado");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
