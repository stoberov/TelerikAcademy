// Problem 1. Odd or Even Integers
//
// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter an integer: ");

        int a = int.Parse(Console.ReadLine());

        if (a % 2 == 0)
        {
            Console.WriteLine(a + " is even.");
        }
        else
        {
            Console.WriteLine(a + " is odd.");
        }
    }
}