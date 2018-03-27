using System;

namespace _01.Largest_Common_End
{
    public class Program
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            var revFirstArray = new string[firstArray.Length];
            var revSecondArray = new string[secondArray.Length];

            for (int i = 0; i < firstArray.Length; i++)
            {
                revFirstArray[i] = firstArray[firstArray.Length - i - 1];
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                revSecondArray[i] = secondArray[secondArray.Length - i - 1];
            }

            Console.WriteLine(Math.Max(GetCommonEndCount(firstArray, secondArray),
                GetCommonEndCount(revFirstArray, revSecondArray)));
        }

        private static int GetCommonEndCount(string[] first, string[] second)
        {
            var sum = 0;
            var minLenght = Math.Min(first.Length, second.Length);

            for (int i = 0; i < minLenght; i++)
            {
                if (first[i] == second[i])
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
