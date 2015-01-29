// Problem 7. Sum of 5 Numbers
// 
// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
using System.Linq;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers in a single line, separated by a space: ");

        string fiveNumbersAsString = Console.ReadLine();

        int sum = 0;

        int[] ints = fiveNumbersAsString.Split(' ').Select(x => int.Parse(x)).ToArray();

        for (int i = 0; i < ints.Length; i++)
        {
            sum += ints[i];
        }

        Console.WriteLine("The sum is: " + sum);
    }
}