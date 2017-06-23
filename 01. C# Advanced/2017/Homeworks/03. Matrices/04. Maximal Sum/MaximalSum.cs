using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_Sum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[][] matrix = new int[dimensions[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var maxSquareRow = 0;
            var maxSquareCol = 0;
            var maxSum = int.MinValue;

            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                    var currentSum = matrix[row][col] +
                                     matrix[row][col + 1] +
                                     matrix[row][col + 2] +
                                     matrix[row + 1][col] +
                                     matrix[row + 2][col] +
                                     matrix[row + 1][col + 1] +
                                     matrix[row + 1][col + 2] +
                                     matrix[row + 2][col + 1] +
                                     matrix[row + 2][col + 2];
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        maxSquareRow = row;
                        maxSquareCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxSquareRow][maxSquareCol]} {matrix[maxSquareRow][maxSquareCol + 1]} {matrix[maxSquareRow][maxSquareCol + 2]}\n" +
                              $"{matrix[maxSquareRow + 1][maxSquareCol]} {matrix[maxSquareRow + 1][maxSquareCol + 1]} {matrix[maxSquareRow + 1][maxSquareCol + 2]}\n" +
                              $"{matrix[maxSquareRow + 2][maxSquareCol]} {matrix[maxSquareRow + 2][maxSquareCol + 1]} {matrix[maxSquareRow + 2][maxSquareCol + 2]}");
        }
    }
}
