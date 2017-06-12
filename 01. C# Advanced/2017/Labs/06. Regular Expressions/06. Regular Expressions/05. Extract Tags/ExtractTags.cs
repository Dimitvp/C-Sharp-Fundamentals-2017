using System;
using System.Text.RegularExpressions;

namespace _05.Extract_Tags
{
    class ExtractTags
    {
        static void Main()
        {
            var input = Console.ReadLine();
            
            while (input != "END")
            {
                Regex regex = new Regex("<.+?>");
                MatchCollection matches = regex.Matches(input);

                foreach (var match in matches)
                {
                    Console.WriteLine(match);

                }

                input = Console.ReadLine();
            }
        }
    }
}
