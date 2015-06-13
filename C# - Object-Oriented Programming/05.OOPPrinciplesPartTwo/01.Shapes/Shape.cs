namespace Shapes
{
    public abstract class Shape
    {
        // Constructor
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        // Properties
        public double Width { get; set; }

        public double Height { get; set; }

        // Methods
        public abstract double CalculateSurfate();
    }
}