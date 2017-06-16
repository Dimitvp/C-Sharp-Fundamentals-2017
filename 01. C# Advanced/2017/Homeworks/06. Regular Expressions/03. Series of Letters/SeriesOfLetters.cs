using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Series_of_Letters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            var input = Console.ReadLine();
            Console.WriteLine(Regex.Replace(input, "([A-Za-z])\\1+", "$1"));
        }
    }
}
