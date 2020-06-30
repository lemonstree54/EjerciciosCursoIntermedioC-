using System;

namespace PruebaLeo
{
    public abstract class DbConexionPrueba
    {
        public string CadenaConexion { get; set; }
        public TimeSpan TiempoEspera { get; set; }

        public DbConexionPrueba(string _cadenaConexion)
        {
            if (_cadenaConexion != null || _cadenaConexion != "")
            {
                CadenaConexion = _cadenaConexion;
            }
            else
            {
                throw new NullReferenceException("La cadena de conexion no es correcta!!!");
            }
        }

        public abstract void AbrirConexion();

        public abstract void CerrarConexion();

    }
}
