// Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
// 
// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
// Use only one loop. Print the result with 5 digits after the decimal point.

using System;
using System.Numerics;

internal class CalculateSum
{
    private static void Main()
    {
        Console.Write("Enter an integer N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter an integer X: ");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        BigInteger factorial = 1;

        int temp;

        for (int i = 1; i <= n; i++)
        {
            temp = i;

            while (temp > 1)
            {
                factorial *= temp;
                temp--;
            }

            sum += (double)factorial / Math.Pow(x, i);
            factorial = 1;
        }

        Console.WriteLine("Sum = {0:F5}", sum);
    }
}