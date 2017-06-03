using System;
using System.Collections.Generic;

namespace _02.Sets_And_Dictionaries
{
    class UniqueUsernames
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            var setOfNames = new HashSet<string>();

            for (int i = 0; i < num; i++)
            {
                var usernames = Console.ReadLine();
                setOfNames.Add(usernames);
            }

            foreach (var username in setOfNames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
