using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace _11.Poisonous_Plants
{
    class PoisonousPlants
    {
        static void Main()
        {
            int plantsNum = int.Parse(Console.ReadLine());
            var plansts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var dayPlantsDie = new int[plantsNum];
            var previousPlant = new Stack<int>();
            previousPlant.Push(0);
            //var watch = new Stopwatch();
            //watch.Start();

            for (int i = 1; i < plantsNum; i++)
            {
                var lastDay = 0;
                while(previousPlant.Count() > 0 && plansts[previousPlant.Peek()] >= plansts[i])
                {
                    lastDay = Math.Max(lastDay, dayPlantsDie[previousPlant.Pop()]);
                    dayPlantsDie[i] = lastDay + 1;// This row is not needed when we are using the IF statment
                }

                //if (previousPlant.Count > 0)
                //{
                //    dayPlantsDie[i] = lastDay + 1;
                //}
                previousPlant.Push(i);
            }
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedTicks);
            Console.WriteLine(dayPlantsDie.Max());
        }
    }
}
