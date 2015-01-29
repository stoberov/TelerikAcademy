// Problem 1. Exchange If Greater
//
// Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

using System;

internal class ExchangeIfGreater
{
    private static void Main()
    {
        Console.Write("Enter first number: ");
        double firstDouble = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondDouble = double.Parse(Console.ReadLine());

        Console.WriteLine("First number was {0} and second number was {1}", firstDouble, secondDouble);

        if (firstDouble > secondDouble)
        {
            firstDouble = firstDouble - secondDouble;
            secondDouble = firstDouble + secondDouble;
            firstDouble = secondDouble - firstDouble;

            Console.WriteLine("Values are now exchanged: {0} {1}",
                    firstDouble, 
                    secondDouble);
        }
        else
        {
            Console.WriteLine("Values remain the same: {0} {1}",
                    firstDouble, 
                    secondDouble);
        }
    }
}