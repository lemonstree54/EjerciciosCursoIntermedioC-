using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexadoresCrear
{


    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "lEO";
            Console.WriteLine(cookie["name"]);
            while(Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
