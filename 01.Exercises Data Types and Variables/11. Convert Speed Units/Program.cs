using System;

namespace _11.Convert_Speed_Units
{
    public class Program
    {
        public static void Main()
        {
            var distance = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());

            float timeInHours = hours + minutes / 60 + seconds / 3600;

            float metersPerSecond = distance / (timeInHours * 3600);
            float kilometersPerHour = (distance / 1000) / timeInHours;
            float milesPerHour = (distance / 1609) / timeInHours;

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
