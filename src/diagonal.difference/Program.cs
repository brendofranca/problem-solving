namespace diagonal.difference
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var arr1 = new List<int> { 1, 2, 3 };
            var arr2 = new List<int> { 4, 5, 6 };
            var arr3 = new List<int> { 9, 8, 9 };

            var result = DiagonalDifference([arr1, arr2, arr3]);

            Console.WriteLine(result);
        }

        private static int DiagonalDifference(List<List<int>> arr)
        {
            var result1 = 0;
            var result2 = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                result1 += arr[i][i];
                result2 += arr[i][arr.Count - i -1];
            }

           return Math.Abs(result1 - result2);
        }
    }
}