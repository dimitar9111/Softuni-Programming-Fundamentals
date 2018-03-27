using System;

namespace _13.Vowel_or_Digit
{
    public class Program
    {
        public static void Main()
        {
            var symbol = char.Parse(Console.ReadLine().ToLower());

            if (symbol == 'a' || symbol == 'u' || symbol == 'i' || symbol == 'o' || symbol == 'e')
            {
                Console.WriteLine("vowel");
            }
            else if (symbol >= '0' && symbol <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
