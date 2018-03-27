using System;

namespace _06.Strings_And_Objects
{
    public class Program
    {
        public static void Main()
        {
            string hello = "Hello";
            string world = "World";

            object helloWorld = hello + " " + world;
            string thirdString = (string)helloWorld;

            Console.WriteLine(thirdString);
        }
    }
}
