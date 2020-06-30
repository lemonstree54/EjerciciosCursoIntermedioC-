using System;

namespace ModificadoresAccesoCrear
{
    public class Persona
    {
        private DateTime _fechaNacimiento;

        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            _fechaNacimiento = fechaNacimiento;
        }

        public DateTime GetFechaNacimiento()
        {
            return _fechaNacimiento;
        }
    }
}
