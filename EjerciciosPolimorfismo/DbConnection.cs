using System;

namespace EjerciciosPolimorfismo
{
    public abstract class DbConnection 
    {
        public string ConnectionString { get; set; }
        public TimeSpan TiempoEspera { get; set; }

        public DbConnection(string _connectionString)
        {
            if (_connectionString != null || _connectionString != "")
            {
                ConnectionString = _connectionString;
            }else
            {
                throw new NullReferenceException("La cadena de conexion no es valida");
            }
            
        }

    public abstract void OpenConnection();

    public abstract void CloseConnection();

    }
}
