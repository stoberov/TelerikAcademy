// Problem 10. Point Inside a Circle & Outside of a Rectangle
// 
// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class CheckPointInsideOrOutside
{
    static void Main()
    {
        Console.Write("Enter X: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter Y: ");
        double y = double.Parse(Console.ReadLine());

        // (X - centerX) ^ 2 + (Y - centerY) ^ 2 < (radius ^ 2)
        bool insideCirle = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)) <= Math.Pow(1.5, 2);

        bool insideRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);

        if (insideCirle && !insideRectangle)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}