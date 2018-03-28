using System;
using System.Collections.Generic;
using System.Globalization;

namespace _01.Count_Work_Days
{
    public class Program
    {
        public static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var datesList = new List<DateTime>()
            {
                DateTime.ParseExact("01-01-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-2016","dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-2016","dd-MM-yyyy",CultureInfo.InvariantCulture)
            };

            int counter = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                DateTime checkDate = new DateTime(2016, date.Month, date.Day);
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday && !datesList.Contains(checkDate))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
