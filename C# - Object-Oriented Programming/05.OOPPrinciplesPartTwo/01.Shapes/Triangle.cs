namespace Shapes
{
    public class Triangle : Shape
    {
        // Constructor
        public Triangle(double width, double height) : base(width, height)
        {
        }

        // Methods
        public override double CalculateSurfate()
        {
            return this.Width * this.Height / 2;
        }
    }
}