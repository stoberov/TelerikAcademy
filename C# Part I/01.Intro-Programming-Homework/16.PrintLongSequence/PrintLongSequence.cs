// Problem 16.* Print Long Sequence
// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i < 1002; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("{0}, ", i);
            }
            else
            {
                Console.Write("{0}, ", -i);
            }
        }

        Console.WriteLine();
    }
}