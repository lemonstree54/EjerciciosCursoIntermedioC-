using System.Collections.Generic;

namespace CamposCrear
{
    public class Cliente
    {
        public int Id;
        public string Name;
        public readonly List<Pedido> pedidos = new List<Pedido>();

        public Cliente(int id)
        {
            this.Id = id;
        }

        public Cliente(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promover()
        {

        }

    }
}
