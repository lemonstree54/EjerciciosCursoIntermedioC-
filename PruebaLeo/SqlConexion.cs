namespace PruebaLeo
{
    public class SqlConexion : DbConexionPrueba
    {
        public SqlConexion(string _cadenaConexion) : base(_cadenaConexion)
        {
            CadenaConexion = _cadenaConexion;
        }
        public override void AbrirConexion()
        {
            System.Console.WriteLine("Conexion SQL abierta");
        }


        public override void CerrarConexion()
        {
            System.Console.WriteLine("Conexion SQL cerrada");
        }
    }
}
