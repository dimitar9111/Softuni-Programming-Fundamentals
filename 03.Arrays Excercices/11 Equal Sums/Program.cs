using System;
using System.Linq;

namespace _11.EqualSums
{
    public class EqualSums
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool founded = false;

            for (int i = 0; i < input.Length; i++)
            {
                int leftside = 0;
                int rightside = 0;

                for (int l = 0; l < i; l++)
                {
                    leftside += input[l];
                }

                for (int r = i + 1; r < input.Length; r++)
                {
                    rightside += input[r];
                }
                if (leftside == rightside)
                {
                    founded = true;
                    Console.WriteLine(i);
                }
            }
            if (!founded)
            {
                Console.WriteLine("no");
            }
        }
    }
}