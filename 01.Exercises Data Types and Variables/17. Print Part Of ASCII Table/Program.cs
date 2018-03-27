using System;

namespace _17.Print_Part_Of_ASCII_Table
{
    public class Program
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var lastNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= lastNum; i++)
            {
                Console.Write("{0} ", (char)i);
            }
            Console.WriteLine();
        }
    }
}
