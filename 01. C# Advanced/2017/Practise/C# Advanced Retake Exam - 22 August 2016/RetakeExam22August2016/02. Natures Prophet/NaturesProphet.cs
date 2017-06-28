using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Natures_Prophet
{
    class NaturesProphet
    {
        static void Main()
        {
            var dimensions =
                Console.ReadLine()
                    .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];

            var garden = new int[rows][];
            var priter = new StringBuilder();

            for (int rowIndex = 0; rowIndex < garden.Length; rowIndex++)
            {
                garden[rowIndex] = new int[cols];
                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    garden[rowIndex][colIndex] = 0;
                }
            }
            string inputLine = String.Empty;
            while ((inputLine = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                var flowerPos = inputLine.Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                var flowerOnRow = flowerPos[0];
                var flowerOnCol = flowerPos[1];

                for (int r = 0; r < garden.Length; r++)
                {
                    garden[r][flowerOnCol]++;
                }

                for (int c = 0; c < garden[0].Length; c++)
                {
                    garden[flowerOnRow][c]++;
                }

                garden[flowerOnRow][flowerOnCol]--;
            }

            for (int rowIndex = 0; rowIndex < garden.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < garden[0].Length; colIndex++)
                {
                    priter.Append(garden[rowIndex][colIndex]).Append(" ");
                }
                priter.AppendLine();
            }

            Console.WriteLine(priter.ToString().TrimEnd());
        }
    }
}
