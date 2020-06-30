using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPost
{

    public class Post
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public TimeSpan FechaCreacion { get; set; }
    
        int CuentaArriba = 0;
        int CuentaAbajo = 0;

        public string Votar(string voto)
        {
            if (voto == "ariba")
            {
                CuentaArriba += 1;
                return voto;
            }
            else
            {
                if (voto == "abajo")
                    CuentaAbajo += 1;
                    return voto;                    
            }                          
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var voto = new Post();            
            Console.WriteLine(voto.Votar("arriba"));
            while(Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
