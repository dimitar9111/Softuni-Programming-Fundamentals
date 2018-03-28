using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Magic_exchangeable_words
{
    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split();
            var firstWord = words[0];
            var secondWord = words[1];

            var map = new Dictionary<char, char>();
            var lenght = Math.Min(firstWord.Length, secondWord.Length);
            var subStr = "";

            for (int i = 0; i < lenght; i++)
            {
                if (!map.ContainsKey(firstWord[i]))
                {
                    if (map.ContainsValue(secondWord[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                    map.Add(firstWord[i], secondWord[i]);
                }
                else
                {
                    if (map[firstWord[i]] != secondWord[i])
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }

            if (firstWord.Length != secondWord.Length)
            {
                if (firstWord.Length > secondWord.Length)
                {
                    subStr = firstWord.Substring(lenght);

                }
                else
                {
                    subStr = secondWord.Substring(lenght);
                }


                foreach (var letter in subStr)
                {
                    if (!map.Keys.Contains(letter) && !map.Values.Contains(letter))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }

            }
            Console.WriteLine("true");
        }
    }
}
