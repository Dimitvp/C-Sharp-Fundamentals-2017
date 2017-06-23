using System;
using System.Linq;

namespace _03._2x2_Squares_in_Matrix
{
    class SquaresInMatrix
    {
        static void Main()
        {
            var dimensions =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            string[][] matrix = new string[dimensions[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            int counter =0;
            
            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    bool IsSquer = matrix[row][col] == matrix[row][col + 1] &&
                        matrix[row + 1][col] == matrix[row][col]&&
                        matrix[row + 1][col + 1] == matrix[row][col];
                    if (IsSquer)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
