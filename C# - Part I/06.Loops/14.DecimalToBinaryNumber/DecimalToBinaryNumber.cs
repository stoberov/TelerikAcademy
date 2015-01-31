// Problem 14. Decimal to Binary Number
// 
// Using loops write a program that converts an integer number to its binary representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

using System;

internal class DecimalToBinaryNumber
{
    private static void Main()
    {
        Console.Write("Decimal: ");
        long input = long.Parse(Console.ReadLine());

        string convertedToBinary = string.Empty;

        while (input > 0)
        {
            convertedToBinary += input % 2;
            input /= 2;
        }

        Console.Write("Binary: ");

        for (int i = convertedToBinary.Length - 1; i >= 0; i--)
        {
            Console.Write(convertedToBinary[i]);
        }

        Console.WriteLine();
    }
}