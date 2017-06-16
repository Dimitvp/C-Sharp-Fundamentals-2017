using System;
using System.Linq;

namespace _07.Functional_Programming
{
    class SortEvenNumbers
    {
        static void Main()
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(NumberParser)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToList()));
        }

        public static int NumberParser(string n)
        {
            return int.Parse(n);
        }
    }
}
