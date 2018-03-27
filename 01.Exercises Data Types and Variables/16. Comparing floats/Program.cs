using System;

namespace _16.Comparing_floats
{
    public class Program
    {
        public static void Main()
        {
            var firstNum = double.Parse(Console.ReadLine());
            var secondNum = double.Parse(Console.ReadLine());

            var equal = true;
            if (Math.Abs(firstNum - secondNum) >= 0.000001)
            {
                equal = false;
            }
            Console.WriteLine(equal);
        }
    }
}
