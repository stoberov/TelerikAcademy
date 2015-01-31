// Problem 9. Matrix of Numbers
// 
// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

using System;

internal class MatrixOfNumbers
{
    private static void Main()
    {
        Console.Write("Enter a positive integer from 1 to 20: ");
        int input = int.Parse(Console.ReadLine());

        for (int row = 0; row < input; row++)
        {
            for (int col = 1 + row; col <= input + row; col++)
            {
                Console.Write(string.Format("{0} ", col));
            }

            Console.WriteLine();
        }
    }
}