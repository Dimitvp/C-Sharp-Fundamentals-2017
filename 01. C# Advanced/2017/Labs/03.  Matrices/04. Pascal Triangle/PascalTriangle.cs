using System;

namespace _04.Pascal_Triangle
{
    class PascalTriangle
    {
        static void Main()
        {
            //Second Solution !Dosent work with big numbers!
            //var maxnumber = long.Parse(Console.ReadLine());
            //for (int i = 0; i < maxnumber; i++)
            //{
            //    long startNumber = 1;
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write(startNumber);
            //        Console.Write(" ");
            //        startNumber = startNumber * (i - j) / (j + 1);
            //    }
            //    Console.WriteLine();
            //}

            //First solution
            ////var height = int.Parse(Console.ReadLine());

            ////long[][] pascal =  new long[height][];

            ////for (int row = 0; row < height; row++)
            ////{
            ////    pascal[row] = new long[row + 1];
            ////    pascal[row][0] = 1;
            ////    pascal[row][pascal[row].Length - 1] = 1;

            ////    for (int col = 1; col < pascal[row].Length - 1; col++)
            ////    {
            ////        pascal[row][col] = pascal[row - 1][col - 1] + pascal[row - 1][col];
            ////    }
            ////}
            ////foreach (var row in pascal)
            ////{
            ////    Console.WriteLine(string.Join(" ", row));
            ////}
        }
    }
}
