using System;
using System.Linq;

namespace _03.Matrices
{
    class MatrixofPalindromes
    {
        static void Main()
        {
            var dimansions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var r = dimansions[0];
            var c = dimansions[1];
            string[,] palindroms = new string[r,c];
            char letter = 'a';

            for (int row = 0; row < palindroms.GetLength(0); row++)
            {
                for (int col = 0; col < c; col++)
                {
                    char outterLetter = letter;
                    outterLetter += (char) row;
                    char middleLetter = letter;
                    middleLetter += (char) row;
                    middleLetter += (char) col;
                    palindroms[row, col] = outterLetter.ToString() + middleLetter + outterLetter;
                    Console.Write(palindroms[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
