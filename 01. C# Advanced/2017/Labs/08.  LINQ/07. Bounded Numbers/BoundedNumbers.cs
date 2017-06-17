using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bounded_Numbers
{
    class BoundedNumbers
    {
        static void Main()
        {
            var bounds = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(n => bounds.Min() <= n && n <= bounds.Max())
                .ToList();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
