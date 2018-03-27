using System;

namespace _15.Fast_Prime_Checker
{
    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool prime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {prime}");
            }
        }
    }
}
