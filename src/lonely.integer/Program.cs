namespace lonely.integer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LonelyInteger([1, 2, 3, 4, 3, 2, 1]);
        }

        private static void LonelyInteger(List<int> arr)
        {
            var result = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.FindAll(x => x == arr[i]).Count == 1)
                {
                    result = arr[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}