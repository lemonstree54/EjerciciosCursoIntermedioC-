using System;

namespace EjercicioClasesCronometroII
{
    public class Cronometro
    {
        private  TimeSpan Inicio { get; set; }
        private TimeSpan Fin { get; set; }

        public Cronometro(TimeSpan _fin, TimeSpan _inicio)
        {
            this.Inicio = _inicio;
            this.Fin = _fin;
        }

        public TimeSpan IniciarCronometro(TimeSpan inicio)
        {
            return inicio;
        }

        public TimeSpan FinalizarCronometro(TimeSpan fin)
        {
            return fin;
        }

        public TimeSpan CalcularCronometro(TimeSpan inicio, TimeSpan fin)
        {
            var intervalo = fin - inicio;
            return intervalo;
        }

    }
}
