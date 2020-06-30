using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace PropiedadesCrear
{

    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Person(new System.DateTime(2010, 1, 20));


            Console.WriteLine(persona.Age);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { };
        }
    }
}
