// Problem 13. Binary to Decimal Number
// 
// Using loops write a program that converts a binary integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.

using System;

internal class BinaryToDecimalNumber
{
    private static void Main()
    {
        Console.Write("In Binary: ");
        string binaryString = Console.ReadLine();

        long convertedToDecimal = 0;

        for (int i = 0; i < binaryString.Length; i++)
        {
            long bitAtPosition = long.Parse(binaryString[binaryString.Length - 1 - i].ToString());
            convertedToDecimal += bitAtPosition * RaiseToPowerOfTwo(i);
        }

        Console.WriteLine(string.Format("In Decimal: {0}", convertedToDecimal));
    }

    private static long RaiseToPowerOfTwo(int position)
    {
        long powerOfTwo = 1;

        for (int i = 0; i < position; i++)
        {
            powerOfTwo *= 2;
        }

        return powerOfTwo;
    }
}