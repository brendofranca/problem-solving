namespace mini.max.sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiniMaxSum([793810624, 895642170, 685903712, 623789054, 468592370]);
        }

        private static void MiniMaxSum(List<Int64> arr)
        {
            var minValue = arr.Min();
            var maxValue = arr.Max();
            var minSum = arr.Sum() - maxValue;
            var maxSum = arr.Sum() - minValue;
            Console.WriteLine(minSum + " " + maxSum);
        }
    }
}
