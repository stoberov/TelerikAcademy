// Problem 1. Sum of 3 Numbers
// 
// Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("Sum is " + (a + b + c));
    }
}