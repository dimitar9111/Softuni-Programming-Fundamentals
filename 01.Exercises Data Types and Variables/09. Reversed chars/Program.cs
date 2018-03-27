using System;

namespace _09.Reversed_chars
{
    public class Program
    {
        public static void Main()
        {
            var first = char.Parse(Console.ReadLine());
            var second = char.Parse(Console.ReadLine());
            var third = char.Parse(Console.ReadLine());

            Console.Write("{0}{1}{2}", third, second, first);
        }
    }
}
