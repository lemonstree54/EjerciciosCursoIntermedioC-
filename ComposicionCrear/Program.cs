using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionCrear
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbmigrator = new DBmigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);
            dbmigrator.Migrate();
            installer.Install();


        }
    }
}
