using System;
using System.Text.RegularExpressions;

namespace _04.Extract_Integer_Numbers
{
    class ExtractIntegerNumbers
    {
        static void Main()
        {
            var input = Console.ReadLine();

            Regex regex = new Regex("\\d+");

            MatchCollection matches = regex.Matches(input);

            foreach (var match in matches)
            {
                Console.WriteLine(match);

            }
        }
    }
}
