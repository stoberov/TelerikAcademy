// Problem 14. Modify a Bit at Given Position
// 
// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        int mask;
        int outcome;

        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter bit position: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter value: ");
        int v = int.Parse(Console.ReadLine());

        if (v == 0)
        {
            mask = ~(1 << p);
            outcome = n & mask;
            Console.WriteLine("The outcome is: {0}", outcome);
        }
        else
        {
            mask = 1 << p;
            outcome = n | mask;
            Console.WriteLine("The outcome is: {0}", outcome);
        }
    }
}