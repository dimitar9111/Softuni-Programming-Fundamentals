using System;
using System.Linq;

namespace _05.Bomb_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bomb = command[0];
            int radius = command[1];

            for (int i = 0; i < firstList.Count; i++)
            {
                if (bomb == firstList[i])
                {

                    int left = Math.Max(0, i - radius);
                    int right = Math.Min(i + radius, firstList.Count - 1);

                    firstList.RemoveRange(i,right-i);
                    firstList.RemoveAt(i);
                    firstList.RemoveRange(left,i-left);
                    i = 0;
                }                              
            }

            Console.WriteLine(firstList.Sum());
        }
    }
}
