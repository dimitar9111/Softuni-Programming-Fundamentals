using System;
using System.Linq;

namespace _08.Most_Frequent_Number
{
    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int repeats = 0;
            int maxRepeats = 0;
            int maxNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                repeats = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        repeats++;
                    }
                    if (repeats > maxRepeats)
                    {
                        maxRepeats = repeats;
                        maxNumber = array[i];
                    }
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
