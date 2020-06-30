using System;
using System.Collections;
using System.Collections.Generic;

namespace EjerciciosHerencia
{
    public class Stack
    {
        private readonly ArrayList lista;

        public Stack()
        {
            lista = new ArrayList();
        }

        public void Push (object obj)
        {
            if (obj != null)
            {
                lista.Add(obj);
            }else
            {
                throw new NullReferenceException();
            }
            
        }

        public object Pop()
        {
                var contador = lista.Count;
                if (contador > 0)
                {
                    var objetoEliminar = lista[contador - 1];
                    lista.RemoveAt(contador - 1);
                    return objetoEliminar;
                }
                else
                {
                    throw new NullReferenceException();
                }

        }

        public void Clear()
        {
            var contador = lista.Count;
            if (contador > 0)
            {
                lista.RemoveRange(0, contador);
            }else
            {
                Console.WriteLine("La pila esta vacia");    
            }          
                
        }

    }
}
