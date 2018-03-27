using System;
using System.Linq;

namespace _04.Sum_Reversed_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                char[] temp = nums[i].ToString().ToCharArray();
                Array.Reverse(temp);
                int num = int.Parse(new string(temp));

                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
