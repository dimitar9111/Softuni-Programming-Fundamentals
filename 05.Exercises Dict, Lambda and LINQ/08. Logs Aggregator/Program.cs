using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Logs_Aggregator
{
    public class Program
    {
        public static void Main()
        {
            var nameDuration = new SortedDictionary<string, int>();
            var nameIp = new Dictionary<string, List<string>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var ipAdress = input[0];
                var name = input[1];
                var duration = input[2];

                if (!nameDuration.ContainsKey(name))
                {
                    nameDuration[name] = new int();
                }
                nameDuration[name] += int.Parse(duration);

                if (!nameIp.ContainsKey(name))
                {
                    nameIp[name] = new List<string>();
                }
                nameIp[name].Add(ipAdress);
            }

            foreach (var name in nameDuration)
            {
                Console.WriteLine($"{name.Key}: {name.Value} [{string.Join(", ", nameIp[name.Key].OrderBy(x => x).Distinct())}]");
            }
        }
    }
}
