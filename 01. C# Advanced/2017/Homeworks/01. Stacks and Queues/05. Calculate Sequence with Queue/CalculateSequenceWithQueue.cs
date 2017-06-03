using System;
using System.Collections;
using System.Collections.Generic;

namespace _05.Calculate_Sequence_with_Queue
{
    class CalculateSequenceWithQueue
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            var listOfNum = new List<long>();
            queue.Enqueue(number);
            listOfNum.Add(number);

            while (queue.Count < 50)
            {
                long currentElemnt = queue.Dequeue();
                long firstNum = currentElemnt + 1;
                long secondNum = (currentElemnt * 2) + 1;
                long thirdNum = currentElemnt + 2;

                queue.Enqueue(firstNum);
                queue.Enqueue(secondNum);
                queue.Enqueue(thirdNum);

                listOfNum.Add(firstNum);
                listOfNum.Add(secondNum);
                listOfNum.Add(thirdNum);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(listOfNum[i] + " ");
            }
                //foreach (var num in listOfNum)
                //{
                //    Console.Write(num + " ");
                //}
        }
    }
}
