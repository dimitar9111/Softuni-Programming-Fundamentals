using System;
using System.Linq;

namespace _10.Pairs_by_Difference
{
    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            var pairs = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] - array[i] == n || array[i] - array[j] == n)
                    {
                        pairs++;
                    }
                }
            }

            Console.WriteLine(pairs / 2);
        }
    }
}
