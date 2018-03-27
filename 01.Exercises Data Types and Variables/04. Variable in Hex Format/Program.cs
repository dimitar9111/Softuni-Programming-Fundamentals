using System;

namespace _04.Variable_in_Hex_Format
{
    public class Program
    {
        public static void Main()
        {
            var first = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(first, 16));
        }
    }
}
