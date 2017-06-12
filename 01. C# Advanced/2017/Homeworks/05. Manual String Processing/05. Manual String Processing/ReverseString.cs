using System;
using System.Linq;
using System.Text;

namespace _05.Manual_String_Processing
{
    class ReverseString
    {
        static void Main()
        {
            var input = Console.ReadLine();

            //Third way - FASTEST aperantly
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }

           sb.ToString();
            Console.WriteLine(sb);

        //Second way
        //var reversed = input.Reverse();
        //foreach (var ch in reversed)
        //{
        //    Console.Write(ch);
        //}
        //Console.WriteLine();

        //First way
        //for (int i = input.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(input[i]);
        //}
        //Console.WriteLine();
    }
}
}
