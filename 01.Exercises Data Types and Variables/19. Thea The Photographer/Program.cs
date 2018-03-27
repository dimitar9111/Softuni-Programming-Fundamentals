using System;

namespace _19.Thea_The_Photographer
{
    public class Program
    {
        public static void Main()
        {
            var amountOfPics = long.Parse(Console.ReadLine());
            var filterTime = long.Parse(Console.ReadLine());
            var goodPicsPercentage = long.Parse(Console.ReadLine());
            var uploadTime = long.Parse(Console.ReadLine());

            long timeInSec = amountOfPics * filterTime;
            double picsAfterFilter = Math.Ceiling((double)(amountOfPics * goodPicsPercentage) / 100);
            timeInSec += (long)(picsAfterFilter * uploadTime);

            long days = 0;
            long hours = 0;
            long minutes = 0;
            long seconds = 0;

            if (timeInSec >= 86400)
            {
                days = timeInSec / 86400;
                timeInSec %= 86400;
            }
            if (timeInSec >= 3600)
            {
                hours = timeInSec / 3600;
                timeInSec %= 3600;
            }
            if (timeInSec >= 60)
            {
                minutes = timeInSec / 60;
                timeInSec %= 60;
            }
            if (timeInSec >= 0)
            {
                seconds = timeInSec;

            }
            Console.WriteLine("{0}:{1:00}:{2:00}:{3:00}", days, hours, minutes, seconds);
        }
    }
}
