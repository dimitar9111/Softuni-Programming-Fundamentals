using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Book_Library
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var autorsDict = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var autor = new Autor();
                var input = Console.ReadLine().Split();
                autor.Name = input[1];
                autor.Price = double.Parse(input[input.Length - 1]);

                if (!autorsDict.ContainsKey(autor.Name))
                {
                    autorsDict[autor.Name] = 0;
                }
                autorsDict[autor.Name] += autor.Price;

            }

            var sortedAutorsDict = autorsDict
                .OrderByDescending(p => p.Value)
                .ThenByDescending(a => a.Key);

            foreach (var autor in sortedAutorsDict)
            {
                Console.WriteLine($"{autor.Key} -> {autor.Value:f2}");
            }
        }
    }
}
