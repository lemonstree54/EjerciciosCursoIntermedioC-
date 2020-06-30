using System;

namespace EjercicioDBConnection
{
    public abstract class DBConnection
    {
        private string ConnectionString { get; set; }
        private TimeSpan WaitTime { get; set; }

        public DBConnection(string _connectionString)
        {

            if (!string.IsNullOrEmpty(_connectionString))
            {
                ConnectionString = _connectionString;
            }
            else
            {
                Console.WriteLine("La cadena de conexion ingresada no es valida....");
                while(Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
            
        }


        public abstract void OpenConnection();

        public abstract void CloseConnection();

    }
}
