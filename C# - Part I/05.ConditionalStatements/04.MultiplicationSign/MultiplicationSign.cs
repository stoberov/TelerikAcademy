// Problem 4. Multiplication Sign
// 
// Write a program that shows the sign (+, - or 0) of the product of three real numbers, / without /calculating it.
// Use a sequence of if operators.

using System;

internal class MultiplicationSign
{
    private static void Main()
    {
        Console.WriteLine("Enter three real numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        // Ensure we use values other than 0; else, the end product would be zero itself
        if (a != 0 && b != 0 && c != 0)
        {
            if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        Console.WriteLine("The sign is '+' !");
                    }
                    else
                    {
                        Console.WriteLine("The sign is '-' !");
                    }
                }
                else
                {
                    if (c > 0)
                    {
                        Console.WriteLine("The sign is: '-' !");
                    }
                    else
                    {
                        Console.WriteLine("The sign is: '+' !");
                    }
                }
            }
            else
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        Console.WriteLine("The sign is '-' !");
                    }
                    else
                    {
                        Console.WriteLine("The sign is '+' !");
                    }
                }
                else
                {
                    if (c > 0)
                    {
                        Console.WriteLine("The sign is: '+' !");
                    }
                    else
                    {
                        Console.WriteLine("The sign is: '-' !");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("The product is 0 and has no sign! ");
        }
    }
}