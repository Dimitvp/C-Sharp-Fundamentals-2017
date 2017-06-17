using System;
using System.Linq;

namespace _08.LINQ
{
    class TakeTwo
    {
        static void Main()
        {
            var input = Console.ReadLine();

            input.Split(' ')
                .Select(int.Parse)
                .Distinct()
                .Where(n => 10 <= n && n <= 20)
                .Take(2)
                .ToList()
                .ForEach(n => Console.Write(n + " "));
        }
    }
}
