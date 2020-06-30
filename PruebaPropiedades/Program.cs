using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace PruebaPropiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona();
            persona.Cumple = new System.DateTime(2010, 1, 20);

            Console.WriteLine(persona.Edad);
            while(Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
