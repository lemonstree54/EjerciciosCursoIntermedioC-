using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClasesPostII
{
    class Program
    {
        static void Main(string[] args)
        {
            var publicacion = new Post();

            Console.WriteLine("What to write a Post? (s or n)");
            var input = char.Parse(Console.ReadLine().ToLower());

            if (input == 's')
            {
                Console.WriteLine("Ingrese el titulo de la publicacion: ");
                publicacion.Titulo = Console.ReadLine().ToLower().ToString();

                Console.WriteLine("Ingrese la descripcion de la publicacion: ");
                publicacion.Descripcion = Console.ReadLine().ToLower().ToString();

                publicacion.FechaPost = DateTime.Now;

                Console.WriteLine();
                while(Console.ReadKey().Key != ConsoleKey.Enter) { }

            }
            else
            {
                Console.WriteLine("Hasta luego...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }


            Console.WriteLine("Desea realizar un voto?: ");
            var votar = char.Parse(Console.ReadLine().ToLower());
                
                if (votar == 's')
                    Console.WriteLine("Ingrese el voto? 1 o 0: ");
                    var voto = Boolean.Parse(Console.ReadLine());
                    var post = new Post();
                    post.Votar(voto);
                    
                    Console.WriteLine(post.Votar(voto));
                    while(Console.ReadKey().Key != ConsoleKey.Enter) { }

                    Console.WriteLine(post.Votar(voto));
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
