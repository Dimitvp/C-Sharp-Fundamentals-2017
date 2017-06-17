using System;
using System.Linq;

namespace _05.Min_Even_Number
{
    class MinEvenNumber
    {
        static void Main()
        {
            try
            {
                Console.WriteLine($"{Console.ReadLine().Split(' ').Select(double.Parse).Where(n => n % 2 == 0).Min():f2}");
            }
            catch (Exception e)
            {

                Console.WriteLine("No match");
            }
        }
    }
}
