using System;

namespace _14.Integer_to_Hex_and_Binary
{
    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            string b = Convert.ToString(number, 16).ToUpper();
            Console.WriteLine(b);

            b = Convert.ToString(number, 2);
            Console.WriteLine(b);
        }
    }
}
