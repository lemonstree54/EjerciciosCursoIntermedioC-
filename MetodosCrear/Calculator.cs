namespace MetodosCrear
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var x in numbers)
            {
                sum += x;
            }
            return sum;
        }
    }
}
