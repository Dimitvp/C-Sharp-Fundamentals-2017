using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06.Truck_Tour
{
    class TruckTour
    {
        static void Main()
        {
            var petrolStationsNum = int.Parse(Console.ReadLine());
            var petrolStations = new Queue<int[]>();

            for (int i = 0; i < petrolStationsNum; i++)
            {
                var petrolStation = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                petrolStations.Enqueue(petrolStation);
            }

            var reachFinal = false;
            var startingIndix = 0;

            while (!reachFinal)
            {
                var totalPetrol = 0;
                for (int i = 0; i <= petrolStationsNum; i++)
                {
                    if (i == petrolStationsNum)
                    {
                        reachFinal = true;
                        break;
                    }

                    var petrolStation = petrolStations.Dequeue();
                    petrolStations.Enqueue(petrolStation);

                    var liters = petrolStation[0];
                    var distanceToNext = petrolStation[1];

                    totalPetrol += liters - distanceToNext;

                    if (totalPetrol < 0)
                    {
                        startingIndix += i + 1;
                        break;
                    }
                }
            }
            Console.WriteLine(startingIndix);
        }
    }
}
