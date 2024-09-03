namespace max.number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxNumber("246753");
        }

        private static void MaxNumber(string number)
        {
            var evenNumbers = number.Where(c => (c - '0') % 2 == 0).OrderByDescending(c => c).ToArray();

            var oddNumbers = number.Where(c => (c - '0') % 2 != 0).OrderByDescending(c => c).ToArray();

            int even = 0, odd = 0;

            char[] result = new char[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                if ((number[i] - '0') % 2 == 0)
                {
                    result[i] = evenNumbers[even++];
                }
                else
                {
                    result[i] = oddNumbers[odd++];
                }
            }

            var maxNumberstr = new string(result);

            var maxNumber = int.Parse(maxNumberstr);

            Console.WriteLine(maxNumber);
        }
    }
}
