using System;

namespace EjercicioDBConnection
{
    public class SQLconnection : DBConnection
    {

        private string connectionString;

        public SQLconnection(string _connectionString) 
            : base(_connectionString)
        {           
            connectionString = _connectionString;
           
        }

        public override void OpenConnection()
        {
            Console.WriteLine("La conexion SQL se ha abierta....");
            Console.WriteLine("Presione enter para cerrarla....");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        public override void CloseConnection()
        {
            Console.WriteLine("La conexion SQL ha sido cerrada...");
            Console.WriteLine("Presione enter para finalizar la ejecucion....");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

    }
}
