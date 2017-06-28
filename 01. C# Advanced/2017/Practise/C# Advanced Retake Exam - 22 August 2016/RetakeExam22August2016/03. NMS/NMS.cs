using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NMS
{
    class NMS
    {
        static void Main()
        {
            var message = new StringBuilder();

            var inputLine = string.Empty;

            while ((inputLine = Console.ReadLine()) != "---NMS SEND---")
            {
                message.Append(inputLine);
            }
            var temp = message.ToString();
            message.Clear();
            for (int i = 0; i < temp.Length - 1; i++)
            {
                if (char.ToLower(temp[i]) <= char.ToLower(temp[i + 1]))
                {
                    message.Append(temp[i]);
                }
            }
                var debbuger = 0;
        }
    }
}
