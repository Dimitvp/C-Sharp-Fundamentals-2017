using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace _04.Basic_Queue_Operations
{
    class BasicQueueOperations
    {
        static void Main()
        {
            var commands = Console.ReadLine()
               .Trim()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            var numbers = Console.ReadLine()
               .Trim()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            var queue = new Queue<int>();

            foreach (var num in numbers)
            {
                queue.Enqueue(num);
            }

            for (int i = 0; i < commands[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(commands[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
