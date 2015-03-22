namespace Matrix
{
    using System;
    using System.Linq;
    
    public class MatrixTest
    {
        public static void Main()
        {
            Matrix<int> testMatrix = new Matrix<int>(3, 3);
            Matrix<int> anotherMatrix = new Matrix<int>(3, 4);

            testMatrix[0, 0] = 3; 
            testMatrix[0, 1] = 4; 
            testMatrix[0, 2] = 6;
            testMatrix[1, 0] = -1; 
            testMatrix[1, 1] = 2; 
            testMatrix[1, 2] = 3;
            testMatrix[2, 0] = 10; 
            testMatrix[2, 1] = 10; 
            testMatrix[2, 2] = 2;

            anotherMatrix[0, 0] = 2; 
            anotherMatrix[0, 1] = 3; 
            anotherMatrix[0, 2] = 5; 
            anotherMatrix[0, 3] = 6;
            anotherMatrix[1, 0] = 1; 
            anotherMatrix[1, 1] = 2; 
            anotherMatrix[1, 2] = 3; 
            anotherMatrix[1, 3] = 1;
            anotherMatrix[2, 0] = 2; 
            anotherMatrix[2, 1] = 4; 
            anotherMatrix[2, 2] = 8; 
            anotherMatrix[2, 3] = 7;

            if (testMatrix)
            {
                Console.WriteLine("True");
            }

            Console.WriteLine();
        }
    }
}