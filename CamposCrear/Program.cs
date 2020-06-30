using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamposCrear
{


    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente(1);
            cliente.pedidos.Add(new Pedido());
            cliente.pedidos.Add(new Pedido());
            cliente.Promover();

            Console.WriteLine(cliente.pedidos.Count());
            while(Console.ReadKey().Key != ConsoleKey.Enter) { }

        }
    }
}
