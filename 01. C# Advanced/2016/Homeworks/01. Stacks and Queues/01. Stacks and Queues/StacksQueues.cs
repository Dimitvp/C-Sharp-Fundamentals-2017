using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Stacks_and_Queues
{
    class StacksQueues
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Trim()
                .Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>();
            foreach (var number in numbers)
            {
                stack.Push(number);
            }

            while (stack.Count != 0)
            {
                int current = stack.Pop();
                Console.Write(current);
                if (stack.Count != 0)
                {
                    Console.Write(" ");
                }
            }

        }
    }
}
