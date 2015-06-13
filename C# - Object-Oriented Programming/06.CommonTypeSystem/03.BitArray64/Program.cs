namespace BitArray64
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            BitArray64 number = new BitArray64(222L);
            BitArray64 otherNumber = new BitArray64(2220L);
            Console.WriteLine("Bits of the number {0}", number.Number);
            foreach (var bit in number)
            {
                Console.Write(string.Format("{0} ", bit));
            }

            Console.WriteLine();
            Console.WriteLine("Bit at position 60 is {0}", number[60]);
            Console.WriteLine("Hash code of {0} is {1}", number.Number, number.GetHashCode());

            Console.WriteLine("number == otherNumber -> {0}", number == otherNumber);
            Console.WriteLine("number != otherNumber -> {0}", number != otherNumber);
            Console.WriteLine("number equals otherNumber -> {0}", number.Equals(otherNumber));
        }
    }
}