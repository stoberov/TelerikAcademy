// Problem 8. Square Root
// Create a console application that calculates and prints the square root of the number 12345.

using System;

class SquareRoot
{
    static void Main()
    {
        int number = 12345;
        double squareRoot = Math.Sqrt(number);

        Console.WriteLine("The square root of 12345 is " + squareRoot);
    }
}