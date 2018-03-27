using System;
using System.Linq;

namespace _02.Rotate_and_Sum
{
    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rotations = int.Parse(Console.ReadLine());

            var sumArray = new int[array.Length];
            for (int i = 0; i < rotations; i++)
            {
                var lastNum = array[array.Length - 1];
                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = lastNum;

                for (int j = 0; j < array.Length; j++)
                {
                    sumArray[j] += array[j];
                }
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
