namespace EjerciciosPolimorfismo
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string _conectionString) :base(_conectionString)
        {
            ConnectionString = _conectionString;
        }

        public override void CloseConnection()
        {
            System.Console.WriteLine("Conexion Oracle cerrada");
        }

        public override void OpenConnection()
        {
            System.Console.WriteLine("Conexion Oracle abierta");
        }
    }
}
