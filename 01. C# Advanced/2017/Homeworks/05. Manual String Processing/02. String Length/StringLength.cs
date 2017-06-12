using System;
using System.Text;

namespace _02.String_Length
{
    class StringLength
    {
        static void Main()
        {
            var input = Console.ReadLine();

            StringBuilder sb = new StringBuilder(20);

            sb.Append(input.Length > 20 ? input.Substring(0, 20) : input.PadRight(20, '*'));

            //if (input.Length > 20)
            //{
            //    sb.Append(input.Substring(0, 20));
            //}
            //else
            //{
            //    sb.Append(input.PadRight(20, '*'));
            //}

            Console.WriteLine(sb);
        }
    }
}
