using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Legendary_Farming
{
    public class Program
    {
        public static void Main()
        {
            var materials = new Dictionary<string, int>();
            materials["shards"] = 0;
            materials["fragments"] = 0;
            materials["motes"] = 0;
            int count = 1;
            string legendaryCheck = "";

            while (count <= 10)
            {
                var str = Console.ReadLine().ToLower();
                var input = str.Split();

                for (int i = 1; i < input.Length; i = i + 2)
                {
                    var material = input[i];
                    var quantity = int.Parse(input[i - 1]);

                    if (!materials.ContainsKey(material))
                    {
                        materials[material] = quantity;
                    }
                    else
                    {
                        materials[material] += quantity;
                    }
                    legendaryCheck = LegendaryItem(materials);

                    if (legendaryCheck != "")
                    {
                        break;
                    }
                }

                if (legendaryCheck != "")
                {
                    break;
                }

                count++;
            }

            Console.WriteLine(legendaryCheck);

            var keyMaterials = materials
                .Take(3)
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key);

            foreach (var item in keyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            var junkMaterials = materials
                .Skip(3)
                .OrderBy(x => x.Key);

            foreach (var item in junkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        static string LegendaryItem(Dictionary<string, int> materials)
        {
            string legendaryItem = "";

            if (materials["fragments"] >= 250)
            {
                materials["fragments"] -= 250;
                legendaryItem = "Valanyr obtained!";
            }
            else if (materials["shards"] >= 250)
            {
                materials["shards"] -= 250;
                legendaryItem = "Shadowmourne obtained!";
            }
            else if (materials["motes"] >= 250)
            {
                materials["motes"] -= 250;
                legendaryItem = "Dragonwrath obtained!";
            }

            return legendaryItem;
        }
    }
}

