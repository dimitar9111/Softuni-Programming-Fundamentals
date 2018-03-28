using System;
using System.Linq;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int currentLenght = 1;
            int maxLenght = 1;
            int currentStart = 0;
            int maxStart = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    currentLenght++;
                    if (currentLenght > maxLenght)
                    {
                        maxLenght = currentLenght;
                        maxStart = currentStart;

                    }
                }
                else
                {
                    currentStart = i;
                    currentLenght = 1;
                }
            }

            var maxSeq = new int[maxLenght];
            for (int i = maxStart; i < maxStart + maxLenght; i++)
            {
                maxSeq[i - maxStart] = array[i];
            }

            Console.WriteLine(string.Join(" ", maxSeq));
        }
    }
}
