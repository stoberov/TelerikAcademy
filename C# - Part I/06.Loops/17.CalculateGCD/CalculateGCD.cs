// Problem 17.* Calculate GCD
// 
// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
// Use the Euclidean algorithm (find it in Internet).

using System;

internal class CalculateGCD
{
    private static void Main()
    {
        Console.Write("First number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int b = int.Parse(Console.ReadLine());

        // Using the Euclidean algorithm
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (a != b)      
        {
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }

        Console.WriteLine("The GCD is {0}", a);
    }
}