using System;
using System.Linq;

namespace _02.Sum_Numbers
{
    class SumNumbers
    {
        static void Main()
        {
            var input = Console.ReadLine();

            Console.WriteLine(input
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Count());

            Console.WriteLine(input
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Sum());
        }
    }
}
