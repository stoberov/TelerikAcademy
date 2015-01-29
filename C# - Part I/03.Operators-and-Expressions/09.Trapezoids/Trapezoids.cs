// Problem 9. Trapezoids
//
// Write an expression that calculates trapezoid's area by given sides a and b and height0 h.

using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter side a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter side b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter height h:");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;
        Console.WriteLine("The area of the trapezoid is {0}", area);
    }
}