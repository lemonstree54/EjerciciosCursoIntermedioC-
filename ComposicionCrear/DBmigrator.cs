using System;

namespace ComposicionCrear
{
    public class DBmigrator
    {
        private readonly Logger _logger;

        public DBmigrator(Logger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("Migrar base de datos...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
