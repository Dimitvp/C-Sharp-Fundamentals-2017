﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Map_Districts
{
    class MapDistricts
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var bound = long.Parse(Console.ReadLine());

            input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(c =>
                {
                    var tokens = c.Split(':');
                    var cityCode = tokens[0];
                    var districtPopulation = long.Parse(tokens[1]);
                    return new {cityCode, districtPopulation};
                })
                .GroupBy(
                    c => c.cityCode,
                    c => c.districtPopulation,
                    (city, population) => new
                    {
                        CityCode = city, Population = population.ToList()
                    })
                .Where(x => x.Population.Sum() >= bound)
                .OrderByDescending(x => x.Population.Sum())
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.CityCode}: {string.Join(" ", x.Population.OrderByDescending(p => p).Take(5))}"));

        }
    }
}
