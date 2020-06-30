using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosHerencia
{



    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            
            var stack = new Stack();
            stack.Push("Leo");
            stack.Push(123);
            stack.Push("abc");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            stack.Clear();
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            stack.Clear();
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
