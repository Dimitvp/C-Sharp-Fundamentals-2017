using System;
using System.Linq;

namespace _02.Diagonal_Difference
{
    class DiagonalDifference
    {
        static void Main()
        {
            var size = int.Parse(Console.ReadLine());

            var matrix = new long[size, size];
            long result = 0;

            for (int row = 0; row < size; row++)
            {
                var nums = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            for (int i = 0; i < size; i++)
            {
                result = result + matrix[i, i];
            }
            for (int i = 0; i < size; i++)
            {
                result = result - matrix[i, size - i - 1];
            }
            Console.WriteLine(Math.Abs(result));
        }
    }
}
