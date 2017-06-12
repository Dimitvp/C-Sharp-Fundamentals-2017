using System;

namespace _04.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();

            var baseN = int.Parse(input[0]);
            var base10 = int.Parse(input[1]);

            for (int i = 0; i < UPPER; i++)
            {
                base10 / baseN;
            }
        }
    }
}
