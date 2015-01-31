// Problem 12.* Randomize the Numbers 1…N
// 
// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Linq;

internal class RandomizeTheNumbersOneToN
{
    private static void Main()
    {
        Random random = new Random();

        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());

        var numbers = Enumerable.Range(1, input);
        var randomized = numbers.OrderBy(a => random.Next());

        foreach (int item in randomized)
        {
            Console.Write(string.Format("{0} ", item));
        }

        Console.WriteLine();
    }
}