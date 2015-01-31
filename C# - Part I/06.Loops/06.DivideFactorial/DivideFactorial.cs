// Problem 6. Calculate N! / K!
// 
// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
// Use only one loop.

using System;

internal class DivideFactorial
{
    private static void Main()
    {
        Console.Write("Enter a positive integer N:");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter a positive integer K:");
        int k = int.Parse(Console.ReadLine());

        int result = 1;

        for (int i = 0; i < (n - k); i++)
        {
            result *= n - i;
        }

        Console.WriteLine("{0}!/{1}! = {2}", n, k, result);
    }
}