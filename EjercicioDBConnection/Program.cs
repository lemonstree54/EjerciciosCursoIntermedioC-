using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese SQL u ORACLE como cadena de conexion: ");
            var input = Console.ReadLine().ToUpper();

            if (!string.IsNullOrEmpty(input))
            {
                if (input == "SQL")
                {
                    var dbconnectionSQL = new SQLconnection(input);
                    dbconnectionSQL.OpenConnection();
                    dbconnectionSQL.CloseConnection();
                }
                else if(input == "ORACLE")
                {
                    var dbconnectionOracle = new OracleConnection("ORACLE");
                    dbconnectionOracle.OpenConnection();
                    dbconnectionOracle.CloseConnection();
                }
            }
            else
            {
                Console.WriteLine("La cadena de conexion NO es correcta.");
                Console.WriteLine("Presione enter para finalizar....");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }

            var connectionSQL = new SQLconnection("SQL");
            var ComandoSQL = new DBCommand(connectionSQL, "SELECT * FROM T1");

            var connectionORACLE = new OracleConnection("ORACLE");
            var ComandoORACLE = new DBCommand(connectionORACLE, "SELECT * FROM T1");






        }
    }
}
