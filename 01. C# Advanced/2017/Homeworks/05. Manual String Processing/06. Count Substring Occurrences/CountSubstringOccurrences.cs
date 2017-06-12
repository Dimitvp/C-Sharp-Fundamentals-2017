using System;

namespace _06.Count_Substring_Occurrences
{
    class CountSubstringOccurrences
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();
            var counter = 0;

            //First way
            foreach (var word in text)
            {
                if (b)
                {
                    counter++;
                }
            }

            //Second way
            //int maxIndex = text.Length - pattern.Length;
            //for (int i = 0; i <= maxIndex; i++)
            //{
            //    string substring = text.Substring(i, pattern.Length);
            //    if (substring.Equals(pattern))
            //    {
            //        counter++;
            //    }
            //}

            Console.WriteLine(counter);

        }
    }
}
