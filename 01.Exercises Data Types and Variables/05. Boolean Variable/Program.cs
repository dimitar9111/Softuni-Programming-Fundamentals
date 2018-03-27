using System;

namespace _05.Boolean_Variable
{
    public class Program
    {
        public static void Main()
        {
            var status = Console.ReadLine();

            if (bool.Parse(status))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
