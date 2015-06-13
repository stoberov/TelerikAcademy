namespace Shapes
{
    public class Square : Shape
    {
        // Constructor
        public Square(double side) : base(side, side)
        {
            this.Width = side;
            this.Height = side;
        }

        // Methods
        public override double CalculateSurfate()
        {
            return this.Width * this.Height;
        }
    }
}