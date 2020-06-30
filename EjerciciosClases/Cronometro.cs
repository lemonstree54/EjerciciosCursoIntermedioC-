using System;

namespace EjerciciosClaseCronometro
{
    public class Cronometro
    {
        public TimeSpan TiempoInicio { get; set; }
        public TimeSpan TiempoFin { get; set; }

        public Cronometro(TimeSpan tiempoInicio, TimeSpan tiempoFin)
        {
            this.TiempoInicio = tiempoInicio;
            this.TiempoFin = tiempoFin;
        }

        public TimeSpan Iniciar(TimeSpan inicio)
        {
            return inicio;
        }

        public TimeSpan Detener(TimeSpan fin)
        {
            return fin;
        }

        public TimeSpan CalcularIntervalo(TimeSpan inicio, TimeSpan fin)
        {
            var tiempo = fin - inicio;
            return tiempo;
        }

    }
}
