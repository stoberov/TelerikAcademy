// Problem 12. Extract Bit from Integer
// 
// Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter bit position: ");
        int p = int.Parse(Console.ReadLine());

        int position = p;
        int mask = 1 << position;

        int nAndMask = n & mask;
        int bit = nAndMask >> position;

        Console.WriteLine("Bit at position {0} is: {1}", p, bit);
    }
}