using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Herencia_Asociacion_Upcasting_Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var pila = new Stack();
            pila.Push(25);
            //pila.Push("Leo");
            pila.Push(DateTime.Now);

            pila.ImprimirLista();

            pila.Pop(1);

            pila.ImprimirLista();

            pila.Clear();

            pila.ImprimirLista();
        }
    }
}
