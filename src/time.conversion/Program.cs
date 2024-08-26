namespace time.conversion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(TimeConversion("12:01:00PM"));
            Console.WriteLine(TimeConversion("12:01:00AM"));
        }

        private static string TimeConversion(string s) => DateTime.Parse(s).TimeOfDay.ToString();
    }
}