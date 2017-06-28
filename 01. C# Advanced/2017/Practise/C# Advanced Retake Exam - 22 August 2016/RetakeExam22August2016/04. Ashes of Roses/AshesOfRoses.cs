using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Ashes_of_Roses
{
    class AshesOfRoses
    {
        static void Main()
        {
            var pattern = new Regex(@"^(Grow)\s<([A-Z.][a-z]+)>\s<([A-Za-z]*\d*)>\s(\d+)$");

            var regionsColorsAmond = new Dictionary<string, Dictionary<string, decimal>>();
            var region = string.Empty;
            var color = string.Empty;
            var amound = 0M;

            var inputLine = String.Empty;
            while ((inputLine = Console.ReadLine()) != "Icarus, Ignite!")
            {
                Match match = pattern.Match(inputLine);
                if (match.Success)
                {
                    region = match.Groups[2].Value;
                    color = match.Groups[3].Value;
                    amound = long.Parse(match.Groups[4].Value);
                    if (!regionsColorsAmond.ContainsKey(region))
                    {
                        regionsColorsAmond[region] = new Dictionary<string, decimal>() {{color,amound}};
                    }else if (!regionsColorsAmond[region].ContainsKey(color))
                    {
                        regionsColorsAmond[region].Add(color, amound);
                    }
                    else
                    {
                        regionsColorsAmond[region][color] += amound;
                    }
                }
                else
                {
                    continue;
                }
            }

            foreach (var reg in regionsColorsAmond.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(y => y.Key))
            {
                Console.WriteLine(reg.Key);
                foreach (var rose in reg.Value.OrderBy(a => a.Value).ThenBy(c => c.Key))
                {
                    Console.WriteLine($"*--{rose.Key} | {rose.Value}");
                }
            }
        }
    }
}
