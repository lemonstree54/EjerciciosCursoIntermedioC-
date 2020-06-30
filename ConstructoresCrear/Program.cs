using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoresCrear
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente(71718516, "Leo");

            var pedido = new Pedidos();
            cliente.pedidos.Add(pedido);
            Console.WriteLine(cliente.Id + " " + cliente.Name);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { };
        }
    }
}
