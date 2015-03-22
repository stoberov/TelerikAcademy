namespace Matrix
{
    using System;
    using System.Linq;

    public class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            T type = default(T);

            if (!((type is double) || (type is int) || (type is decimal)))
            {
                throw new ApplicationException("T must be of type double,int or decimal");
            }
            else
            {
                this.rows = rows;
                this.cols = cols;
                this.matrix = new T[rows, cols];
            }
        }

        public T this[int row, int col]
        {
            get
            {
                this.CheckMatrixRange(row, col);
                return this.matrix[row, col];
            }

            set
            {
                this.CheckMatrixRange(row, col);
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if ((first.rows != second.rows) || (first.cols != second.cols))
            {
                throw new ApplicationException("Matrices must haven same size.");
            }

            Matrix<T> resultMatrix = new Matrix<T>(first.rows, first.cols);
            
            for (int i = 0; i < first.rows; i++)
            {
                for (int j = 0; j < first.cols; j++)
                {
                    resultMatrix[i, j] = (dynamic)first[i, j] + second[i, j];
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if ((first.rows != second.rows) || (first.cols != second.cols))
            {
                throw new ApplicationException("Matrices must be of the same size.");
            }

            Matrix<T> resultMatrix = new Matrix<T>(first.rows, first.cols);
            
            for (int i = 0; i < first.rows; i++)
            {
                for (int j = 0; j < first.cols; j++)
                {
                    resultMatrix[i, j] = (dynamic)first[i, j] - second[i, j];
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.cols != second.rows)
            {
                throw new ApplicationException("Matrices must haven same size.");
            }

            Matrix<T> resultMatrix = new Matrix<T>(first.rows, second.cols);

            for (int i = 0; i < first.rows; i++)
            {
                for (int j = 0; j < second.cols; j++)
                {
                    for (int k = 0; k < first.cols; k++)
                    {
                        resultMatrix[i, j] += (dynamic)first[i, k] * second[k, j];
                    }
                }
            }

            return resultMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    if ((dynamic)matrix[i, j] != default(T))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    if ((dynamic)matrix[i, j] != default(T))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void CheckMatrixRange(int row, int col)
        {
            if ((row < 0) || (row >= this.rows) || (col < 0) || (col >= this.cols))
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}