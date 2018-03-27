using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Longest_Increasing_Subsequence
{
    public class Program
    {
        public static void Main()
        {
            var seq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var lenght = new int[seq.Length];
            int maxLen = 0;
            int lastIndex = -1;

            var prev = new int[seq.Length];

            for (int x = 0; x < seq.Length; x++)
            {
                lenght[x] = 1;
                prev[x] = -1;
                for (int i = 0; i < x; i++)
                {
                    if (seq[i] < seq[x] && lenght[i] >= lenght[x])
                    {
                        lenght[x] = 1 + lenght[i];
                        prev[x] = i;
                    }
                }
                if (lenght[x] > maxLen)
                {
                    maxLen = lenght[x];
                    lastIndex = x;
                }
            }

            Console.WriteLine(string.Join(" ", RestoreList(seq, prev, lastIndex, maxLen)));
        }

        static int[] RestoreList(int[] seq, int[] prev, int lastIndex, int maxLen)
        {
            var longestSeq = new List<int>();
            for (int i = 0; i < maxLen; i++)
            {
                longestSeq.Add(seq[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            longestSeq.Reverse();
            return longestSeq.ToArray();
        }
    }
}
