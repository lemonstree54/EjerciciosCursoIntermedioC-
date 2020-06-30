using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPolimorfismo
{

    class Program
    {
        static void Main(string[] args)
        {
            var Sql = new SqlConnection("123");
            while (Console.ReadKey().Key != ConsoleKey.Enter){ }
            Sql.OpenConnection();

            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Sql.CloseConnection();
            
            while(Console.ReadKey().Key != ConsoleKey.Enter) { }
            var Ora = new OracleConnection("456");
            Ora.OpenConnection();

            while(Console.ReadKey().Key != ConsoleKey.Enter) { }
            Ora.CloseConnection();
            while(Console.ReadKey().Key != ConsoleKey.Enter) { }

            var comandoSql = new DbCommand(new SqlConnection("sql"), "Comando sql");
            comandoSql.Ejecutar();
            while (Console.ReadKey().Key != ConsoleKey.Enter) { };
            var comandoOracle = new DbCommand(new OracleConnection("oracle"), "comando oracle");
            comandoOracle.Ejecutar();
            while (Console.ReadKey().Key != ConsoleKey.Enter) { };

        }

    }

}
