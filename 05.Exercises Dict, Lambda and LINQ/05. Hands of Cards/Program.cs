using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Hands_of_Cards
{
    public class Program
    {
        public static void Main()
        {
            var cardPowers = GetPower();
            var cardTypes = GetTypes();
            var cardPoints = new Dictionary<string, HashSet<int>>();

            var inputText = Console.ReadLine().Split(':');

            while (inputText[0] != "JOKER")
            {
                var player = inputText[0];
                var cards = inputText[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in cards)
                {
                    var cardPower = card.Substring(0, card.Length - 1);
                    var cardType = card.Substring(card.Length - 1);

                    var sumPoints = cardPowers[cardPower] * cardTypes[cardType];

                    if (!cardPoints.ContainsKey(player))
                    {
                        cardPoints[player] = new HashSet<int>();
                    }
                    cardPoints[player].Add(sumPoints);
                }

                inputText = Console.ReadLine().Split(':');
            }

            foreach (var pair in cardPoints)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Sum()}");
            }

        }

        private static Dictionary<string, int> GetTypes()
        {
            var types = new Dictionary<string, int>();
            types["C"] = 1;
            types["D"] = 2;
            types["H"] = 3;
            types["S"] = 4;

            return types;
        }

        private static Dictionary<string, int> GetPower()
        {
            var power = new Dictionary<string, int>();
            for (int i = 2; i <= 10; i++)
            {
                power[i.ToString()] = i;
            }

            power["J"] = 11;
            power["Q"] = 12;
            power["K"] = 13;
            power["A"] = 14;

            return power;
        }
    }
}
