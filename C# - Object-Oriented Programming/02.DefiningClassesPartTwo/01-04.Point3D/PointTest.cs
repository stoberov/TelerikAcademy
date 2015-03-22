namespace Point3D
{
    using System;
    
    public class PointTest
    {
        public static void Main()
        {
            Console.WriteLine(Point3D.OriginPointO);
            Console.WriteLine(new string('-', 25));

            double testDistance = Distance.CalculateDistanceBetweenTwoPoints(Point3D.OriginPointO, new Point3D(2, 4, 13));
            Console.WriteLine(testDistance);
            Console.WriteLine(new string('-', 25));

            PathStorage.LoadPaths();
            PathStorage.PrintPaths();

            PathStorage.SavePath();
            PathStorage.PrintPaths();
        }
    }
}
