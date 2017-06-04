using System;
using System.Linq;
using System.Security.Cryptography;

namespace _03.Group_Numbers
{
    class GroupNumbers
    {
        static void Main()
        {
            //First way
            int[] numbers = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] sizes = new int[3];

            foreach (var number in numbers)
            {
                int reminder = Math.Abs(number % 3);
                sizes[reminder]++;
            }

            int[][] matrix = new int[3][]
            {
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]]
            };

            int[] offsets = new int[3];
            foreach (var number in numbers)
            {
                int remider = Math.Abs(number % 3);
                int index = offsets[remider];
                offsets[remider]++;
                matrix[remider][index] = number;
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            //Second way
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            //var numbers = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //var zero = numbers.Where(n => Math.Abs(n) % 3 == 0);
            //var one = numbers.Where(n => Math.Abs(n) % 3 == 1);
            //var two = numbers.Where(n => Math.Abs(n) % 3 == 2);

            //watch.Stop();
            //Console.WriteLine(watch.ElapsedTicks);

            //Console.WriteLine(string.Join(" ", zero));
            //Console.WriteLine(string.Join(" ", one));
            //Console.WriteLine(string.Join(" ", two));
        }
    }
}
