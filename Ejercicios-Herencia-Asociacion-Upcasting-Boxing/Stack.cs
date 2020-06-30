using System;
using System.Collections;

namespace Ejercicios_Herencia_Asociacion_Upcasting_Boxing
{
    public class Stack
    {

        private readonly ArrayList Lista;
        
        public Stack()
        {
            Lista = new ArrayList();
        }

        public void Push(object obj)
        {
            try
            {
                if (obj != null)
                    Lista.Add(obj);
            }
            catch (Exception)
            {
                throw new NullReferenceException();

            }
                           
        }

        public void Pop(int posicion)
        {
            try
            {
                if (posicion >= 0 || posicion < Lista.Count)
                    Lista.RemoveAt(posicion);
            }
            catch (Exception)
            {
                throw new NullReferenceException();
            }
        }

        
        public void Clear()
        {
            Lista.Clear();
        }


        public void ImprimirLista()
        {
            try
            {
                if (Lista.Count > 0)
                {
                    for (var i = 0; i < Lista.Count; i++)
                    {
                        Console.WriteLine("El valor del indice " + i + " es:" + Lista[i]);
                    }
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                }
                else
                {
                    Console.WriteLine("La lista no contiene valores para mostrar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                }
            }
            catch (Exception)
            {

                throw new NullReferenceException();
            }

        }

    }
}
