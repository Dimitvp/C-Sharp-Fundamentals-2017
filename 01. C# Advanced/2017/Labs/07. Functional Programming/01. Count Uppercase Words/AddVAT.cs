using System;
using System.Linq;

namespace _01.Count_Uppercase_Words
{
    class AddVAT
    {
        static void Main()
        {
            var input = Console.ReadLine();

            input.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n *= 1.2)
                .ToList()
                .ForEach(n => Console.WriteLine($"{n:n2}"));
        }
    }
}
