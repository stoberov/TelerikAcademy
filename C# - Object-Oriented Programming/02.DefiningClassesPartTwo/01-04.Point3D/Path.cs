namespace Point3D
{
    using System.Collections.Generic;
    
    public class Path
    {
        private List<Point3D> sequenceOfPoints;

        public Path()
            : this(new List<Point3D>())
        {
        }

        public Path(List<Point3D> points)
        {
            this.sequenceOfPoints = new List<Point3D>(points);
        }

        public Point3D[] GetPoints
        {
            get
            {
                return this.sequenceOfPoints.ToArray();
            }
        }

        public void AddPoint(Point3D point)
        {
            this.sequenceOfPoints.Add(point);
        }
    }
}
