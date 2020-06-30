using System;

namespace EjerciciosPolimorfismo
{
    public class DbCommand
    {
        private readonly DbConnection _conexion;
        private readonly string _TSQL;

        public DbCommand(DbConnection conexion,   string TSQL)
        {
            if (TSQL == null && TSQL == "")
            {
                throw new NullReferenceException("El comando no es valido.");
            }

            _conexion = conexion ?? throw new NullReferenceException("La conexion no es valida.");
            _TSQL = TSQL;

        }

        

        public void Ejecutar()
        {
            _conexion.OpenConnection();
            Console.WriteLine("Ejecutando: {0}", _TSQL);
            _conexion.CloseConnection();

        }

    }
}
