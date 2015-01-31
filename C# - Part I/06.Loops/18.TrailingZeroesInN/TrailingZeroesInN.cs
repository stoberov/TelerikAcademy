// Problem 18.* Trailing Zeroes in N!
// 
// Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
// Your program should work well for very big numbers, e.g. n=100000.
using System;
using System.Numerics;

internal class TrailingZeroesInN
{
    private static void Main()
    {
        Console.Write("Enter a number: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        int zeroCounter = 0;
        while (factorial % 10 == 0)
        {
            zeroCounter++;
            factorial /= 10;
        }

        Console.WriteLine(string.Format("Trailing zeroes: {0}", zeroCounter));
    }
}