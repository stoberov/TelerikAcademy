// Problem 7. Sort 3 Numbers with Nested Ifs
// 
// Write a program that enters 3 real numbers and prdoubles them sorted in descending / order.
// Use nested if statements.
// Note: Don’t use arrays and the built-in sorting functionality.

using System;

internal class SortThreeNumbersWithNestedIFs
{
    private static void Main()
    {
        Console.Write("Enter first value: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second value: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter third value: ");
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("First, Second, Third: {0}, {1} and {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("First, Third, Second: {0}, {1} and {2}", a, c, b);
                }
            }
            else
            {
                Console.WriteLine("Third, First, Second: {0}, {1} and {2}", c, a, b);
            }
        }
        else if (b > c)
        {
            if (a > c)
            {
                Console.WriteLine("Second, First, Third: {0}, {1} and {2}", b, a, c);
            }
            else
            {
                Console.WriteLine("Second, Third, First: {0}, {1} and {2}", b, c, a);
            }
        }
        else
        {
            Console.WriteLine("Third, Second, First: {0}, {1} and {2}", c, b, a);
        }
    }
}