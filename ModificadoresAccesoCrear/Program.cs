using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAccesoCrear
{

    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona();
            persona.SetFechaNacimiento(DateTime.Now);

            Console.WriteLine(persona.GetFechaNacimiento());
            while(Console.ReadKey().Key != ConsoleKey.Enter) { }
            
        }
    }
}
