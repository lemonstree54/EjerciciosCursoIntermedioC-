namespace EjerciciosPolimorfismo
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string _connectionString) : base(_connectionString)
        {
            ConnectionString = _connectionString;
        }

        public override void CloseConnection()
        {
            System.Console.WriteLine("Conexion Sql cerrada");
        }

        public override void OpenConnection()
        {
            System.Console.WriteLine("Conexion Sql abierta");
        }
    }
}
