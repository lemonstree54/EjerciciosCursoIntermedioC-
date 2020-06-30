using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLeo
{

    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConexion("Hola sql");
            sql.AbrirConexion();
            sql.CerrarConexion();
            while (Console.ReadKey().Key != ConsoleKey.Enter) { } ;

            var comando = new DbComando(new SqlConexion("SQL"), "Comando SQL a ejecutar");
            comando.EjecutarComando();
            while(Console.ReadKey().Key != ConsoleKey.Enter) { };
        }
    }
}
