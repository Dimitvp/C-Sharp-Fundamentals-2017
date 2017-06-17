using System;
using System.Linq;


namespace _06.Find_and_Sum_Integers
{
    class FindAndSumIntegers
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var nums = input
                .Split(' ')
                .Select(w =>
                {
                    long value;
                    bool success = long.TryParse(w, out value);
                    return new {value, success};
                })
                .Where(s => s.success)
                .Select(n => n.value)
                .ToList();

            if (nums.Count != 0)
            {
                Console.WriteLine(nums.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
