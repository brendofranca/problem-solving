namespace plus.minus
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PlusMinus([1, 1, 0, -1, -1]);
        }

        private static void PlusMinus(List<int> numbers)
        {
            var size = numbers.Count;

            var totalPositiveNumbers = (decimal)numbers.Count(x => x > 0);

            var totalNegativeNumbers = (decimal)numbers.Count(x => x < 0);

            var totalZeroNumbers = (decimal)numbers.Count(x => x == 0);

            Console.WriteLine((totalPositiveNumbers / size).ToString("F6"));

            Console.WriteLine((totalNegativeNumbers / size).ToString("F6"));

            Console.WriteLine((totalZeroNumbers / size).ToString("F6"));
        }
    }
}