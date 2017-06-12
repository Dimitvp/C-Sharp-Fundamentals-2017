using System;
using System.Text.RegularExpressions;

namespace _03.Non_Digit_Count
{
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine();

            Regex regex = new Regex("\\D");

            MatchCollection match = regex.Matches(text);
            Console.WriteLine($"Non-digits: {match.Count}");
        }
    }
}
