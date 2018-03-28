using System;
using System.Numerics;

namespace _02.Convert_from_base_N_to_base_10
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();

            BigInteger result = 0;
            var number = input[1].ToCharArray();
            var baseNum = int.Parse(input[0]);

            for (int i = 0; i < number.Length; i++)
            {
                var temp = (int)char.GetNumericValue(number[number.Length - 1 - i]) * BigInteger.Pow(baseNum, i);
                result += temp;
            }

            Console.WriteLine(result);
        }
    }
}
