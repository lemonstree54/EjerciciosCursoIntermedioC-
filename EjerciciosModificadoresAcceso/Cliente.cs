using System;

namespace EjerciciosModificadoresAcceso
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private void Promover()
        {
            Console.WriteLine("ensayo");
        }

        protected void CalificarCliente()
        {
            Console.WriteLine("ensayo calificar");
        }

        protected internal void Weirdo()
        {

        }

    }
}
