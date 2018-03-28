using System;
using System.Linq;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            var result = "";
            BigInteger number = input[1];
            BigInteger baseNum = input[0];

            while (number > 0)
            {
                var rem = number % baseNum;
                result = rem + result;
                number /= baseNum;
            }

            Console.WriteLine(result);
        }
    }
}
