using System;

namespace PruebaLeo
{
    public class DbComando
    {
        private readonly DbConexionPrueba _DbConexion;
        private readonly string _TSQL;

        public DbComando(DbConexionPrueba dbConexion, string TSQL)
        {
            if (TSQL == null && TSQL == "")
            {
                throw new NullReferenceException("El comando no es correcto!!!");
            }

            if (dbConexion == null)
            {
                throw new NullReferenceException("La conexion no es correcta!!!");
            }
            _TSQL = TSQL;
            _DbConexion = dbConexion;
        }

        public void EjecutarComando()
        {
            _DbConexion.AbrirConexion();
            Console.WriteLine("Ejecutando comando!!!");
            _DbConexion.CerrarConexion();
        }
    }
}
