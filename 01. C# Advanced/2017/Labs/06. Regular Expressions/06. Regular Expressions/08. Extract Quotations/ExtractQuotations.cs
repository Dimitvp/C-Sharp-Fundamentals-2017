using System;
using System.Text.RegularExpressions;

namespace _08.Extract_Quotations
{
    class ExtractQuotations
    {
        static void Main()
        {
            var input = Console.ReadLine();

            Regex regex = new Regex("('|\")(.+?)\\1");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
