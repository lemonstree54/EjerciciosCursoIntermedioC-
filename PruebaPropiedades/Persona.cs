using System;

namespace PruebaPropiedades
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public DateTime Cumple { get; set; }

        public int Edad
        {
            get
            {
                var timespan = DateTime.Today - Cumple;
                var annios = timespan.Days / 365;

                return annios;
            }

        }


    }
}
