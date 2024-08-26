namespace sparse.arrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var result = SparseArrays(["aa", "bb", "cc"], ["aa", " bb", "cc"]);

            var display = "[" + string.Join(", ", result.Select(n => n.ToString())) + "]";

            Console.WriteLine(display);
        }

        private static List<int> SparseArrays(List<string> strings, List<string> queries)
        {
            var countDict = new Dictionary<string, int>();

            foreach (var str in strings)
            {
                if (countDict.TryGetValue(str, out int value))
                {
                    countDict[str] = ++value;
                }
                else
                {
                    countDict[str] = 1;
                }
            }

            var results = new List<int>();

            foreach (var query in queries)
            {
                if (countDict.TryGetValue(query, out int count))
                {
                    results.Add(count);
                }
                else
                {
                    results.Add(0);
                }
            }

            return results;
        }
    }
}