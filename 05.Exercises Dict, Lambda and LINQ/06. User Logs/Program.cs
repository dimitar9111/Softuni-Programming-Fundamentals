using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.User_Logs
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ', '=');
            var messageInfo = new SortedDictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                var userName = input[input.Length - 1];
                var ipAdress = input[1];

                if (!messageInfo.ContainsKey(userName))
                {
                    messageInfo[userName] = new Dictionary<string, int>();
                }
                if (!messageInfo[userName].ContainsKey(ipAdress))
                {
                    messageInfo[userName][ipAdress] = 0;
                }
                messageInfo[userName][ipAdress]++;

                input = Console.ReadLine().Split(' ', '=');
            }

            foreach (var user in messageInfo)
            {
                Console.WriteLine($"{user.Key}:");

                foreach (var ip in user.Value)
                {
                    if (ip.Equals(user.Value.Last()))
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value}.");
                    }
                    else
                    {
                        Console.Write($"{ip.Key} => {ip.Value}, ");
                    }
                }
            }
        }
    }
}
