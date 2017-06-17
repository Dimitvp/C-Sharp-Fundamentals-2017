using System;
using System.Linq;

namespace _02.Upper_Strings
{
    class UpperStrings
    {
        static void Main()
        {
            var input = Console.ReadLine();

            input.Split(' ')
                .Select(n => n.ToUpper())
                .ToList()
                .ForEach(n => Console.Write(n + " "));
        }
    }
}
