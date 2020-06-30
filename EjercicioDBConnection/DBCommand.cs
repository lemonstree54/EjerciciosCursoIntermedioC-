using System;

namespace EjercicioDBConnection
{
    public class DBCommand 
    {
        private DBConnection Connection { get; set; }
        public string Command { get; set; }

        public DBCommand(DBConnection _connection, string _command)
        {
            if(_connection != null)
            {
                Connection = _connection;

                if (!string.IsNullOrEmpty(_command))
                {
                    Command = _command;
                }
                else
                {
                    throw new ArgumentNullException("El comando ingresado no es valido...");
                }
                
            }
            else
            {
                Console.WriteLine("La conexion ingresada no es correcta...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }

        }

        public void ExcuteCommand(string command)
        {
            Connection.OpenConnection();
            Console.WriteLine(Command);
            Connection.CloseConnection();
        }

    }
}
