namespace Shapes
{
    using System;
    using System.Collections.Generic;
    
    public class TestShapes
    {
        private static void Main()
        {
            // Create array
            var shapes = new List<Shape>();

            // Add shapes
            shapes.Add(new Rectangle(10, 5));
            shapes.Add(new Triangle(10, 5));
            shapes.Add(new Square(10));
            
            // Calculate Surfaces
            foreach (var shape in shapes)
            {
                Console.Write(string.Format("Area of {0}: ", shape.GetType().Name));
                Console.WriteLine(shape.CalculateSurfate());
            }
        }
    }
}