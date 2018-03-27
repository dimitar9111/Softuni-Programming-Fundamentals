using System;
using System.Linq;

namespace _05.Compare_Char_Arrays
{
    public class Program
    {
        public static void Main()
        {
            var firstArr = Console.ReadLine().Split().Select(char.Parse).ToArray();
            var secondArr = Console.ReadLine().Split().Select(char.Parse).ToArray();

            if (firstArr.Length < secondArr.Length)
            {
                Output(firstArr, secondArr);
            }
            else if (secondArr.Length < firstArr.Length)
            {
                Output(secondArr, firstArr);
            }
            else if (secondArr.Length == firstArr.Length)
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] > secondArr[i])
                    {
                        Output(secondArr, firstArr);
                        break;
                    }
                    if (firstArr[i] < secondArr[i])
                    {
                        Output(firstArr, secondArr);
                        break;
                    }
                    if (firstArr[i] == secondArr[i] && i == firstArr.Length - 1)
                    {
                        Output(firstArr, secondArr);
                        break;
                    }
                }
            }
        }

        private static void Output(char[] first, char[] second)
        {
            Console.WriteLine(string.Join("", first));
            Console.WriteLine(string.Join("", second));
        }
    }
}
