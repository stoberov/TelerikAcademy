// Problem 19.** Spiral Matrix
// 
// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

using System;

internal class SpiralMatrix
{
    private static void Main()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int currentRow = 0;
        int currentCol = 0;

        string direction = "right";
        for (int i = 0; i < n * n; i++)
        {
            switch (direction)
            {
                case "right":
                    if (currentCol == n || matrix[currentRow, currentCol] != 0)
                    {
                        direction = "down";
                        currentCol--;
                        currentRow++;
                        if (i < ((n * n) - 1))
                        {
                            i--;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = i + 1;
                        currentCol++;
                    }

                    break;
                case "down":
                    if (currentRow == n || matrix[currentRow, currentCol] != 0)
                    {
                        direction = "left";
                        currentCol--;
                        currentRow--;
                        if (i < ((n * n) - 1))
                        {
                            i--;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = i + 1;
                        currentRow++;
                    }

                    break;
                case "left":
                    if (currentCol < 0 || matrix[currentRow, currentCol] != 0)
                    {
                        direction = "up";
                        currentRow--;
                        currentCol++;
                        if (i < ((n * n) - 1))
                        {
                            i--;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = i + 1;
                        currentCol--;
                    }

                    break;
                case "up":
                    if (currentRow < 1 || matrix[currentRow, currentCol] != 0)
                    {
                        direction = "right";
                        currentCol++;
                        currentRow++;
                        if (i < ((n * n) - 1))
                        {
                            i--;
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = i + 1;
                        currentRow--;
                    }

                    break;
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row, col].ToString().PadLeft(4, ' '));
            }

            Console.WriteLine();
        }
    }
}