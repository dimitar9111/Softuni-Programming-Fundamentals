using System;

namespace _07.Exchange_Variable_Values
{
    public class Program
    {
        public static void Main()
        {
            var a = 5;
            var b = 10;

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }
}
