using System;
using System.Globalization;

namespace _01.Softuni_Coffee_Orders
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            decimal price = 0;
            decimal finalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = int.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                price = ((daysInMonth * capsulesCount) * pricePerCapsule);

                Console.WriteLine("The price for the coffee is: ${0:f2}", price);
                finalPrice += price;
            }

            Console.WriteLine("Total: ${0:f2}", finalPrice);
        }
    }
}
