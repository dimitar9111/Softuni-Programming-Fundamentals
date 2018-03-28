using System;
using System.Linq;

namespace _06.SumBigNumbers
{
    public class Program
    {
        public static void Main()
        {
            var first = Console.ReadLine().Trim();
            var second = Console.ReadLine().Trim();

            var len = Math.Max(first.Length, second.Length);
            first = first.PadLeft(len + 1, '0');
            second = second.PadLeft(len + 1, '0');

            int[] firstArr = first.Select(x => int.Parse(x.ToString())).ToArray();
            int[] secondArr = second.Select(x => int.Parse(x.ToString())).ToArray();
            int[] sum = new int[firstArr.Length];

            int rem = 0;
            for (int i = sum.Length-1; i >= 0; i--)
            {

                int summed = firstArr[i] + secondArr[i] + rem;
                sum[i] = summed % 10;
                if (summed > 9)
                {
                    rem = 1;
                }
                else
                {
                    rem = 0;
                }

            }

            Console.WriteLine(string.Join("", sum.SkipWhile(x => x == 0)));
        }
    }
}
