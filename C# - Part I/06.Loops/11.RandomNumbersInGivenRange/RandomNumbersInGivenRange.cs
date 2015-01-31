// Problem 11. Random Numbers in Given Range
// 
// Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

internal class RandomNumbersInGivenRange
{
    private static void Main()
    {
        Random random = new Random();

        Console.Write("Enter an integer N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter min: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Enter max: ");
        int max = int.Parse(Console.ReadLine());

        if (min == max)
        {
            Console.WriteLine("Min and Max should be different.");
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(random.Next(min, max));
            }
        }
    }
}