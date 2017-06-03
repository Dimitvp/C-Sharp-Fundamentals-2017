using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _03.Maximum_Element
{
    class MaximumElement
    {
        static void Main()
        {
            int numOfQuerys = int.Parse(Console.ReadLine());

            var myStack = new Stack<int>();
            var maxStack = new Stack<int>();

            for (int i = 0; i < numOfQuerys; i++)
            {
                var query = Console.ReadLine()
                    .Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (query[0] == 1)
                {
                    myStack.Push(query[1]);
                    if (maxStack.Count == 0 || query[1] >= maxStack.Peek())
                    {
                        maxStack.Push(query[1]);
                    }
                }
                else if (query[0] == 2)
                {
                    var elementAtTop = myStack.Pop();
                    var currentMaxNum = maxStack.Peek();

                    if (elementAtTop == currentMaxNum)
                    {
                        maxStack.Pop();
                    }
                }
                else
                {
                    Console.WriteLine(maxStack.Peek());
                }
            }
        }
    }
}
