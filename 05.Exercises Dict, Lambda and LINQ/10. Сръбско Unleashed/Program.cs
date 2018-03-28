using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Сръбско_Unleashed
{
    public class Program
    {
        public static void Main()
        {
            var concertInfo = new Dictionary<string, Dictionary<string, long>>();

            var rawInput = Console.ReadLine().Split().ToList();
            while (rawInput[0] != "End")
            {
                if (rawInput.Count >= 4)
                {
                    int ticketPrice, ticketCount, index;
                    if (int.TryParse(rawInput[rawInput.Count - 1], out ticketCount) &&
                       int.TryParse(rawInput[rawInput.Count - 2], out ticketPrice))
                    {
                        index = rawInput.FindIndex(x => x.StartsWith("@"));
                        if (index >= 0)
                        {
                            ticketCount = int.Parse(rawInput[rawInput.Count - 1]);
                            ticketPrice = int.Parse(rawInput[rawInput.Count - 2]);
                            rawInput.RemoveRange(rawInput.Count - 2, 2);

                            var venueArr = rawInput.GetRange(index, rawInput.Count - index);
                            var singerArr = rawInput.GetRange(0, rawInput.Count - venueArr.Count);

                            var venue = string.Join(" ", venueArr);
                            venue = venue.Remove(0, 1);
                            var singer = string.Join(" ", singerArr);

                            if (!concertInfo.ContainsKey(venue))
                            {
                                concertInfo[venue] = new Dictionary<string, long>();
                            }
                            if (!concertInfo[venue].ContainsKey(singer))
                            {
                                concertInfo[venue][singer] = new long();
                            }
                            concertInfo[venue][singer] += ticketCount * ticketPrice;
                        }
                    }
                }
                rawInput = Console.ReadLine().Split().ToList();
            }

            foreach (var venue in concertInfo)
            {
                Console.WriteLine($"{venue.Key}");
                foreach (var singer in concertInfo[venue.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
