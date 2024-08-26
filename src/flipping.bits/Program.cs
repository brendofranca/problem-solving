namespace flipping.bits
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FlippingBits(3);
            FlippingBits(2147483647);
            FlippingBits(1);
            FlippingBits(0);
        }

        private static void FlippingBits(long n)
        {
            Console.WriteLine(~(uint)n);
        }
    }
}