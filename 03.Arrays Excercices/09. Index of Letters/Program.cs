using System;

namespace _09.Index_of_Letters
{
    public class Program
    {
        public static void Main()
        {
            var str = Console.ReadLine();
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (str[i].ToString().Contains(alphabet[j]))
                    {
                        Console.WriteLine("{0} -> {1}", str[i], j);
                    }
                }
            }
        }
    }
}
