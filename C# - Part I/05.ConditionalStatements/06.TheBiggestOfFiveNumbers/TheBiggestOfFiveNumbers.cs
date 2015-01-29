// Problem 6. The Biggest of Five Numbers
// 
// Write a program that finds the biggest of five numbers by using only five if statements.

using System;

internal class TheBiggestOfFiveNumbers
{
    private static void Main()
    {
        Console.Write("Enter first value: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second value: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third value: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Enter fourth value: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Enter fifth value: ");
        int e = int.Parse(Console.ReadLine());

        int biggestValue = a;

        if (biggestValue < b)
        {
            biggestValue = b;
        }

        if (biggestValue < c)
        {
            biggestValue = c;
        }

        if (biggestValue < d)
        {
            biggestValue = d;
        }

        if (biggestValue < e)
        {
            biggestValue = e;
        }

        Console.WriteLine("The biggest value is: {0}", biggestValue);
    }
}