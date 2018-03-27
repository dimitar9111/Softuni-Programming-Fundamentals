using System;

namespace _04.Sieve_of_Eratosthenes
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            EratMethod(n);
        }

        private static void EratMethod(int n)
        {
            var primes = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }

            primes[0] = primes[1] = false;

            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    Console.WriteLine(i);
                    for (int j = 2; j <= n; j++)
                    {
                        if (i * j <= n && i * j >= 0)
                        {
                            primes[i * j] = false;
                        }
                    }
                }
            }
        }
    }
}
