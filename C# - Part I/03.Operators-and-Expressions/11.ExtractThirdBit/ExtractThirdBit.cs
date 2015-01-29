// Problem 11. Bitwise: Extract Bit #3
// 
// Using bitwise operators, write an expression for finding the value of the bit #3  of /a /given unsigned integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0.

using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.Write("Enter an integer: ");

        uint myVar = uint.Parse(Console.ReadLine());

        int position = 3;
        int mask = 1 << position;

        int myVarAndMask = (int)myVar & mask;
        int bit = myVarAndMask >> position;

        Console.WriteLine("Bit at position three: " + bit);
    }
}