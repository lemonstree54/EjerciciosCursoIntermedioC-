using System;

namespace ComposicionCrear
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
            while(Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

    }
}
