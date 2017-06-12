using System;
using System.Text.RegularExpressions;

namespace _06.Regular_Expressions
{
    class MatchCount
    {
        static void Main()
        {
            var pattern = Console.ReadLine();
            var text = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(text);

            Console.WriteLine($"{match.Count}");
        }
    }
}
