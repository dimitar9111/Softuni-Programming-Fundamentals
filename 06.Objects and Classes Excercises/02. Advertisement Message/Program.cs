using System;

namespace _02.Advertisement_Message
{
    public class Program
    {
        public static void Main()
        {
            string[] phrases = new string[]
                {"Excellent product.", "Such a great product.", "I always use that product.",
                    "Best product of its category.","Exceptional product.", "I can’t live without this product."};
            string[] events = new string[]
                {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] autor = new string[]
                {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] city = new string[]
                {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            Random rnd = new Random();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{phrases[rnd.Next(phrases.Length)]} {events[rnd.Next(events.Length)]} {autor[rnd.Next(autor.Length)]} – {city[rnd.Next(city.Length)]}");
            }
        }
    }
}
