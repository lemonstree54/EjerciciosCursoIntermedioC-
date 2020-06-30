using System.Collections.Generic;

namespace ConstructoresCrear
{
    public class Cliente
    {
        public int Id;
        public string Name;
        public List<Pedidos> pedidos;

        public Cliente()
        {
            pedidos = new List<Pedidos>();
        }

        public Cliente(int id)
            :this()
        {
            this.Id = id;
        }

        public Cliente(int id, string name)
            :this(id)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
