namespace Shapes
{
    public class Rectangle : Shape
    {
        // Constructor
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        // Methods
        public override double CalculateSurfate()
        {
            return this.Width * this.Height;
        }
    }
}