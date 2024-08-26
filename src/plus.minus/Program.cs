namespace plus.minus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlusMinus([1, 1, 0, -1, -1]);
        }

        private static void PlusMinus(List<int> arr)
        {
            var arrSize = arr.Count;
            var countPositive = 0;
            var countNegative = 0;
            var countZero = 0;

            for (int i = 0; i < arrSize; i++)
            {
                if (arr[i] > 0)
                {
                    countPositive++;
                }
                else if (arr[i] < 0)
                {
                    countNegative++;
                }
                else
                {
                    countZero++;
                }
            }

            Console.WriteLine(((decimal)countPositive / arrSize).ToString("F6"));
            Console.WriteLine(((decimal)countNegative / arrSize).ToString("F6"));
            Console.WriteLine(((decimal)countZero / arrSize).ToString("F6"));
        }
    }
}