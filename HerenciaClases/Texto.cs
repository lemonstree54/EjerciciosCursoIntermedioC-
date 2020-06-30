using System;

namespace HerenciaClases
{
    public class Texto: PresentacionObjeto
    {
        public int TamanoTexto { get; set; }
        public string NombreTexto { get; set; }

        public void AddHipervinculo(string url)
        {
            Console.WriteLine("Se ha adicionado el hipervinculo " + url);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
