using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Increasing_Subsequence
{
    public class Program
    {
        public static void Main()
        {
            var listOfNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] operation = Console.ReadLine().Split(' ').ToArray();

            var containsResult = new List<int>();

            while (operation[0] != "print")
            {
                switch (operation[0])
                {
                    case "add":
                        Add(listOfNums, operation);
                        break;
                    case "addMany":
                        AddMany(listOfNums, operation);
                        break;
                    case "contains":
                        containsResult.Add(Contains(listOfNums, operation));
                        break;
                    case "remove":
                        Remove(listOfNums, operation);
                        break;
                    case "shift":
                        Shifts(listOfNums, operation);
                        break;
                    case "sumPairs":
                        SumPairs(listOfNums);
                        break;
                }
                operation = Console.ReadLine().Split(' ').ToArray();

            }

            foreach (var item in containsResult)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("[{0}]", string.Join(", ", listOfNums));
        }

        private static List<int> Add(List<int> nums, string[] operation)
        {
            nums.Insert(Convert.ToInt32(operation[1]), Convert.ToInt32(operation[2]));

            return nums;
        }

        private static List<int> AddMany(List<int> nums, string[] operation)
        {
            var addMany = new List<int>();
            for (int i = 2; i < operation.Length; i++)
            {
                addMany.Add(Convert.ToInt32(operation[i]));
            }

            nums.InsertRange(Convert.ToInt32(operation[1]), addMany);

            return nums;
        }

        private static int Contains(List<int> nums, string[] operation)
        {
            int contains = -1;
            if (nums.Contains(Convert.ToInt32(operation[1])))
            {
                contains = nums.IndexOf(Convert.ToInt32(operation[1]));
            }

            return contains;
        }

        private static List<int> Remove(List<int> nums, string[] operation)
        {
            nums.RemoveAt(Convert.ToInt32(operation[1]));

            return nums;
        }

        private static List<int> Shifts(List<int> nums, string[] operation)
        {
            var shifteNums = new List<int>();
            int position = Convert.ToInt32(operation[1]) % nums.Count;
            shifteNums = nums.Take(position).ToList();
            nums.RemoveRange(0, position);
            nums.AddRange(shifteNums);

            return nums;
        }

        private static List<int> SumPairs(List<int> nums)
        {
            var summedList = new List<int>();
            for (int i = 0; i < nums.Count - 1; i += 2)
            {
                summedList.Add(nums[i] + nums[i + 1]);
            }

            if (nums.Count % 2 != 0)
            {
                summedList.Add(nums.Last());
            }

            nums.Clear();
            nums.InsertRange(0, summedList);
            return nums;
        }
    }
}