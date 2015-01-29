// Problem 13. Check a Bit at Given Position
// 
// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        bool isOne = true;

        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter bit position: ");
        int p = int.Parse(Console.ReadLine());

        int position = p;
        int mask = 1 << position;

        int nAndMask = n & mask;
        int bit = nAndMask >> position;

        if (bit == 0)
        {
            isOne = false;
        }

        Console.WriteLine(isOne ? "True (1)" : "False (0)");
    }
}