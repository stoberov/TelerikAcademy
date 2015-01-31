// Problem 7. Calculate N! / (K! * (N-K)!)
// 
// In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
// Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops

using System;
using System.Numerics;

internal class CalculateFactorialExpressions
{
    private static void Main()
    {
        Console.Write("Enter an integer N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter an integer K: ");
        int k = int.Parse(Console.ReadLine());

        int difference = n - k;

        // N!/K!
        BigInteger leftSide = 1;

        // (N-K)!
        BigInteger rightSide = 1;

        // N!/K!
        while (n - k >= 1)
        {
            leftSide *= n;
            n--;
        }

        // (N-K)!
        while (difference > 1)
        {
            rightSide *= difference;
            difference--;
        }

        Console.WriteLine(leftSide / rightSide);
    }
}