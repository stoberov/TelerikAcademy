// Problem 10. Odd and Even Product
// 
// You are given n integers (given in a single line, separated by a space).
// Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
// Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
using System.Linq;

internal class OddAndEvenProduct
{
    private static void Main()
    {
        long productOdd = 1;
        long productEven = 1;

        string input = Console.ReadLine().Trim();

        long[] longs = input.Split(' ').Select(x => long.Parse(x)).ToArray();

        for (int i = 0; i < longs.Length; i++)
        {
            if (i % 2 == 0)
            {
                productOdd *= longs[i];
            }
            else
            {
                productEven *= longs[i];
            }
        }

        Console.WriteLine(string.Format("Product odd = {0}", productOdd));
        Console.WriteLine(string.Format("Product even = {0}", productEven));

        Console.WriteLine(productOdd == productEven ? "Yes" : "No"); 
    }
}