using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Fix_Emails
{
    public class Program
    {
        public static void Main()
        {
            var eMailAdressBook = new Dictionary<string,string>();
            for (int i = 0; ; i++)
            {
                string name = Console.ReadLine();
                if (name=="stop")
                {
                    break;
                }

                string eMail = Console.ReadLine();
                if (eMailAdressBook.ContainsKey(name))
                {
                    eMailAdressBook[name] = eMail;
                }
                else
                {
                    eMailAdressBook.Add(name,eMail);
                }
            }

            foreach (var item in eMailAdressBook)
            {
                int lenght = item.Value.Length - 2;
                var domain = item
                    .Value
                    .Skip(lenght)
                    .Take(2)
                    .ToArray();
                if (domain[1]=='k' || domain[1]=='s')
                {
                    eMailAdressBook.Remove(item.Key);
                }
            }

            foreach (var item in eMailAdressBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
