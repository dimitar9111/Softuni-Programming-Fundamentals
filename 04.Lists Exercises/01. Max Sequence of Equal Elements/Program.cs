using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Max_Sequence_of_Equal_Elements
{
    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int currentStart = 0;
            int currentLenght = 1;
            int bestStart = 0;
            int bestLenght = 0;
            nums.Add(int.MaxValue);

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    currentStart = i - currentLenght;
                    currentLenght++;

                    if (currentLenght > bestLenght)
                    {
                        bestLenght = currentLenght;
                        bestStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLenght = 1;
                }
            }

            var sequence = new List<int>();
            if (bestLenght == 0)
            {
                Console.WriteLine(nums[0]);
            }
            for (int i = bestStart; i < bestStart + bestLenght; i++)
            {
                sequence.Add(nums[i]);
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
