using System;
using System.Text.RegularExpressions;

namespace _02.Vowel_Count
{
    class VowelCount
    {
        static void Main()
        {
            var text = Console.ReadLine();

            Regex regex = new Regex(@"[aeiouyAEIOUY]");

            MatchCollection match = regex.Matches(text);
            Console.WriteLine($"Vowels: {match.Count}");
        }
    }
}
