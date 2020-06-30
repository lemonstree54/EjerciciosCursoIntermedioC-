using System;

namespace PropiedadesCrear
{
    public class Person
    {
        public Person(DateTime cumpleanios)
        {
            Cumpleanios = cumpleanios;
        }
        public DateTime Cumpleanios { get; private set; }

        public int Age
        {
            get 
            {
                var timespan = DateTime.Today - Cumpleanios;
                var anios = timespan.Days / 365;

                return anios;
            }
        }


    }
}
