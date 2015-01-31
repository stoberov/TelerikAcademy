// Problem 3. Min, Max, Sum and Average of N Numbers
// 
// Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

using System;

internal class MinMaxSumAverageOfNNumber
{
    private static void Main()
    {
        int min = int.MaxValue;
        int max = int.MinValue;
        long sum = 0;

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            if (currentNumber > max)
            {
                max = currentNumber;
            }

            if (currentNumber < min)
            {
                min = currentNumber;
            }

            sum += currentNumber;
        }

        double average = (double)sum / n;

        Console.WriteLine("Min: {0:F2}", min);
        Console.WriteLine("Max: {0:F2}", max);
        Console.WriteLine("Sum: {0:F2}", sum);
        Console.WriteLine("Average: {0:F2}", average);
    }
}