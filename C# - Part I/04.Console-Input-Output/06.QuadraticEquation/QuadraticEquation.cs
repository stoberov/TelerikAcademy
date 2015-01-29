// Problem 6. Quadratic Equation
// 
// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - (4 * a * c);        // First, we need to find the discriminant

        // If discriminant equals 0 => one real root
        if (discriminant == 0)
        {
            double oneDoubleRealRoot = (-b) / (2 * a);
            Console.WriteLine("One Double Real Root = " + oneDoubleRealRoot);
        }

        // If discriminant is more than 0 => two real roots
        else if (discriminant > 0)      
        {
            double firstRealRoot = ((-b) + Math.Sqrt((b * b - 4 * a * c))) / (2 * a);
            double secondRealRoot = ((-b) - Math.Sqrt((b * b - 4 * a * c))) / (2 * a);

            Console.WriteLine("Two real roots: " + firstRealRoot + " and " + secondRealRoot);
        }

        // If discriminant is less than 0 => no real roots
        else
        {
            Console.WriteLine("No real roots");
        }
    }
}