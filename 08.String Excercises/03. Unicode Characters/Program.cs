using System;
using System.Linq;

namespace _03.Unicode_Characters
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToArray();

            foreach (var item in input)
            {
                Console.Write("\\u{0}", ((int)item).ToString("x4"));
            }
        }
    }
}
