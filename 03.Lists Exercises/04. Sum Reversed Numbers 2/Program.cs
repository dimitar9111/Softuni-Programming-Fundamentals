using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 05BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine().Split().Select(char.Parse).ToList();
            var secondList = new List<char>();

         

            Console.WriteLine(string.Join(" ",secondList));
        }
    }
}
