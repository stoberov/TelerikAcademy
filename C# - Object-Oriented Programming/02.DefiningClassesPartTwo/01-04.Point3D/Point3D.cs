namespace Point3D
{
    using System;
    
    public struct Point3D
    {
        private static readonly Point3D PointO = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D OriginPointO
        {
            get
            {
                return PointO;
            }
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public override string ToString()
        {
            string point = string.Format("X = {0}, Y = {1}, Z = {2}", this.X, this.Y, this.Z);
            return point;
        }
    }
}
