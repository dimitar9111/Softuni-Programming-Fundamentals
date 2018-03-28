using System;
using System.Linq;

namespace _07.Multiply_big_number
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("0");
                return;
            }

            int[] inputArr = input.Select(x => int.Parse(x.ToString())).ToArray();
            var sum = new int[input.Length + 1];

            var rem = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                var mult = inputArr[i] * num + rem;
                rem = 0;
                sum[i + 1] = mult % 10;
                if (mult > 9)
                {
                    rem = mult / 10;
                }
            }

            if (rem != 0)
            {
                sum[0] = rem;
            }

            Console.WriteLine(string.Join("", sum.SkipWhile(x => x == 0)));
        }
    }
}
