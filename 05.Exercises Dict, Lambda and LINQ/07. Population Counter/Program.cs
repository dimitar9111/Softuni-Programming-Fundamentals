using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Population_Counter
{
    public class Program
    {
        public static void Main()
        {
            var populationDict = new Dictionary<string, Dictionary<string, double>>();

            var input = Console.ReadLine().Split('|');
            while (input[0] != "report")
            {
                var country = input[1];
                var city = input[0];
                var population = double.Parse(input[2]);

                if (!populationDict.ContainsKey(country))
                {
                    populationDict[country] = new Dictionary<string, double>();
                }
                populationDict[country][city] = population;

                input = Console.ReadLine().Split('|');
            }

            var temp = new Dictionary<string, double>();
            foreach (var country in populationDict)
            {
                temp[country.Key] = country.Value.Values.Sum();

            }

            foreach (var item in temp.OrderByDescending(n => n.Value))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value})");

                foreach (var city in populationDict[item.Key].OrderByDescending(n => n.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
