namespace PruebaLeo
{
    public class OracleConexion : DbConexionPrueba
    {
        public OracleConexion(string _cadenaConexion) :base(_cadenaConexion)
        {
            CadenaConexion = _cadenaConexion;
        }

        public override void AbrirConexion()
        {
            System.Console.WriteLine("Conexion Oracle abierta");
        }

        public override void CerrarConexion()
        {
            System.Console.WriteLine("Conexion Oracle cerrada");
        }
    }
}
