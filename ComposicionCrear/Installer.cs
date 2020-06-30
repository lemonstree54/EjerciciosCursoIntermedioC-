using System;

namespace ComposicionCrear
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            this._logger = logger;
        }

        public void Install()
        {
            _logger.Log("Instalando la base de datos...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
