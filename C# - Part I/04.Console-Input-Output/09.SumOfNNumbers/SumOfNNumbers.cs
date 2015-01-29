// Problem 9. Sum of n Numbers
// 
// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        Console.WriteLine("Enter all numbers: ");
        for (int i = n; i > 0; i--)
        {
            int m = int.Parse(Console.ReadLine());
            sum += m;
        }

        Console.WriteLine("The sum is " + sum);
    }
}