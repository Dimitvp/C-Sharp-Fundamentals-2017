using System;
using System.Linq;

namespace _04.Average_of_Doubles
{
    class AverageOfDoubles
    {
        static void Main()
        {
            var num = Console.ReadLine();

            Console.WriteLine("{0:f2}", num
                .Split(' ')
                .Select(double.Parse)
                .Average());
        }
    }
}
