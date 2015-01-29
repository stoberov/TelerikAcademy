// Problem 5. The Biggest of 3 Numbers
// 
// Write a program that finds the biggest of three numbers.

using System;

internal class TheBiggestOfThreeNumbers
{
    private static void Main()
    {
        Console.Write("Enter first integer: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third integer: ");
        int c = int.Parse(Console.ReadLine());

        if ((a >= b) && (a >= c))
        {
            Console.WriteLine("The biggest integer is the first one");
        }
        else if ((b >= a) && (b >= c))
        {
            Console.WriteLine("The biggest integer is the second one");
        }
        else
        {
            Console.WriteLine("The biggest integer is the third one");
        }
    }
}