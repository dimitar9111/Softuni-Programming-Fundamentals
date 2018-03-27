using System;
using System.Linq;

namespace _03.Fold_and_Sum
{
    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = array.Length / 4;
            var innerRow = new int[2 * k];
            var outerRow = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                innerRow[i] = array[2 * k - k + i];
            }

            for (int i = 0; i < k; i++)
            {
                outerRow[i] = array[k - 1 - i];
                outerRow[k + i] = array[4 * k - i - 1];
            }

            var sumArray = new int[2 * k];
            for (int i = 0; i < 2 * k; i++)
            {
                sumArray[i] = innerRow[i] + outerRow[i];
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
