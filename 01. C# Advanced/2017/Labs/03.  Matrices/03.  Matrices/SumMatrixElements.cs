using System;
using System.Dynamic;
using System.Linq;

namespace _03.Matrices
{
    class SumMatrixElements
    {
        static void Main()
        {
            var matrixSizes = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            int[][] matrix = new int[int.Parse(matrixSizes[0])][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            int maxSum = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    maxSum += matrix[row][col];
                }
            }

            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix[0].Length);
            Console.WriteLine(maxSum);

            //First Way
            //int[,] matrix = new int[int.Parse(matrixSizes[0]), int.Parse(matrixSizes[1])];

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    var inputRow = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        matrix[row, col] = inputRow[col];
            //    }
            //}

            //int maxSum = 0;
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        maxSum += matrix[row, col];
            //    }
            //}

            //Console.WriteLine(matrix.GetLength(0));
            //Console.WriteLine(matrix.GetLength(1));
            //Console.WriteLine(maxSum);
        }
    }
}
