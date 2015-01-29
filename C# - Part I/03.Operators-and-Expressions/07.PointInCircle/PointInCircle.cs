// Problem 7. Point in a Circle
// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("Enter point X: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter point Y: ");
        double y = double.Parse(Console.ReadLine());

        bool pythagoreanTheorem = ((x * x) + (y * y) <= (2 * 2));    // Pythagorean Theorem

        if (pythagoreanTheorem)
        {
            Console.WriteLine("Point (X, Y) is inside the circle.");
        }
        else
        {
            Console.WriteLine("Point (X, Y) is outside the circle.");
        }
    }
}