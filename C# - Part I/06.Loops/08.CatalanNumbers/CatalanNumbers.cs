// Problem 8. Catalan Numbers
//
// In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
// Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;

internal class CatalanNumbers
{
    private static void Main()
    {
        Console.Write("Enter an integer N: ");
        int n = int.Parse(Console.ReadLine());

        if (n == 0 || n == 1)
        {
            Console.WriteLine(1);
            return;
        }

        double product = 1;

        for (int i = 2; i <= n; i++)
        {
            product *= (double)(n + i) / i;
        }

        Console.WriteLine(product);
    }
}