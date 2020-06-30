using System;

namespace EjercicioDBConnection
{
    public class OracleConnection : DBConnection
    {
        public string connectionString;

        public OracleConnection(string _connectionString)
            :base (_connectionString)
        {
            connectionString = _connectionString;
        }

        public override void OpenConnection()
        {
            Console.WriteLine("La conexion ORACLE ha sido abierta...");
            Console.WriteLine("Presione enter para cerrarla....");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        public override void CloseConnection()
        {
            Console.WriteLine("La conexion ORACLE ha sido cerrada...");
            Console.WriteLine("Presione enter para finalizar la ejecucion....");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

    }
}
