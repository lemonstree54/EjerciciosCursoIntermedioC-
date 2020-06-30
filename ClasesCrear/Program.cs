using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCrear
{

    public class Persona{

        public string Nombre;

        public void Introducir(string para)
        {
            Console.WriteLine("Hola {0}, Yo soy {1}", para, Nombre);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        public static Persona Parse(string str)
        {
            var persona = new Persona();
            persona.Nombre = str;

            return persona;

        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            var persona = Persona.Parse("Leo");
            persona.Introducir("Flaco");
        }
    }
}
