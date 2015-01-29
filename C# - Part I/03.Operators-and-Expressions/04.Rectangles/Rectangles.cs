// Problem 4. Rectangles
// 
// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter is " + (2 * (width + height)));
        Console.WriteLine("Area is " + (width * height));
    }
}