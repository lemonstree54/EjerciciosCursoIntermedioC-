namespace ensayo
{
    public class Calculadora
    {
        public int Sumar(params int[] numeros)
        {
            var suma = 0;
            foreach (var numero in numeros)
            {
                suma += numero;
            }
            return suma;
        }
    }
}
