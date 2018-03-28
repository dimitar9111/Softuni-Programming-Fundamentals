using System;
using System.Linq;

namespace _04.Character_Multiplier
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var first = input[0].ToArray();
            var second = input[1].ToArray();
            long sum = 0;

            var minLenght = Math.Min(first.Length, second.Length);
            var maxLenght = Math.Max(first.Length, second.Length);

            for (int i = 0; i < minLenght; i++)
            {
                sum += Convert.ToInt32(first[i]) * Convert.ToInt32(second[i]);
            }

            if (minLenght != maxLenght)
            {
                if (first.Length > second.Length)
                {
                    for (int i = minLenght; i < maxLenght; i++)
                    {
                        sum += first[i];
                    }
                }
                else
                {
                    for (int i = minLenght; i < maxLenght; i++)
                    {
                        sum += second[i];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
