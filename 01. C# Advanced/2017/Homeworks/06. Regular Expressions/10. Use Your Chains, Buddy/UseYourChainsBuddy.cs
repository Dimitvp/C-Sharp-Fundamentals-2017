using System;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Text.RegularExpressions;

namespace _10.Use_Your_Chains__Buddy
{
    class UseYourChainsBuddy
    {
        static void Main()
        {
            var input = Console.ReadLine();

            Regex regex = new Regex("<p>(.*?)<\\/p>");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var witespaces = "[^a-z0-9]+";
                var reminder = match.Groups[1].Value;
                var replaced = Regex.Replace(reminder, witespaces, " ");
                var pattern = @"\s+";

               

                foreach (var charectar in replaced)
                {
                    if (charectar >='a'&&charectar<='m')
                    {
                       Console.Write((char) (charectar + 13));
                    }
                    else if (charectar >= 'n' && charectar <= 'z')
                    {
                        Console.Write((char) (charectar - 13));
                    }
                    else
                    {
                        Console.Write(charectar);
                    }
                }
                
            }
        }
    }
}
