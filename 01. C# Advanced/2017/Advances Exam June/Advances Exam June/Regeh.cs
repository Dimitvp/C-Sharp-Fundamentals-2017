using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Advances_Exam_June
{
    class Regeh
    {
        static void Main()
        {
            var pattern = new Regex(@"\[([^\[]+)<(\d+)REGEH(\d+)>([^\]]+)\]");
            var indexes = new List<int>();
            var output = new StringBuilder();
            var inputLine = Console.ReadLine();
            MatchCollection matches = pattern.Matches(inputLine);
            var firstIndex = 0;
            var secondIndex = 0;

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    firstIndex = int.Parse(match.Groups[2].ToString());
                    secondIndex = int.Parse(match.Groups[3].ToString());
                    indexes.Add(firstIndex);
                    indexes.Add(secondIndex);
                } 
            }

            for (int i = 0; i < inputLine.Length; i++)
            {
                if (inputLine[i] == indexes[0])
                {
                    output.Append(inputLine[i]);
                }
                
            }
        }
    }
}
