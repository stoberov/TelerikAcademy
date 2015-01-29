// Problem 3. Circle Perimeter and Area
// 
// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius r: ");
        double radius = double.Parse(Console.ReadLine());

        double circlePerimeter = (2 * radius * Math.PI);
        double circleArea = (Math.PI * Math.Pow(radius, 2));

        Console.WriteLine("The perimeter of circle is: {0:0.00}", circlePerimeter);
        Console.WriteLine("The area of circle is: {0:0.00}", circleArea);
    }
}