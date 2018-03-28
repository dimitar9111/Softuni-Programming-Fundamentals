using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, SortedDictionary<string, List<double>>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                string type = input[0];
                string name = input[1];

                double damage;
                if (input[2]!="null")
                {
                    damage = double.Parse(input[2]);
                }
                else
                {
                    damage = 45;
                }

                double health;
                if (input[3] != "null")
                {
                    health = double.Parse(input[3]);
                }
                else
                {
                    health = 250;
                }

                double armor;
                if (input[4] != "null")
                {
                    armor = double.Parse(input[4]);
                }
                else
                {
                    armor = 10;
                }

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, List<double>>();
                }


                dragons[type][name] = new List<double> {damage,health,armor};
            }

            foreach (var item in dragons)
            {
                var dragonType = item.Key;
                var dragonStats = item.Value;

                var averageDamage = dragonStats.Values.Average(a => a[0]);
                var averageHealth = dragonStats.Values.Average(a => a[1]);
                var averageArmor = dragonStats.Values.Average(a => a[2]);

                    Console.WriteLine($"{dragonType}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                    foreach (var dragon in dragonStats)
                    {
                        Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                    }
                }
            }
        }
    }

