using System;

namespace _01.Sweet_Dessert
{
    public class Program
    {
        public static void Main()
        {
            var cash = double.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananaPrice = double.Parse(Console.ReadLine());
            var eggPrice = double.Parse(Console.ReadLine());
            var berriesPrice = double.Parse(Console.ReadLine());

            double sixPortionPrice = 2 * bananaPrice + 4 * eggPrice + 0.2 * berriesPrice;
            int portionIndex = guests / 6;

            if (guests % 6 != 0)
            {
                portionIndex++;
            }

            double calculatedPrice = sixPortionPrice * portionIndex;
            if (calculatedPrice <= cash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", calculatedPrice);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.",
                    calculatedPrice - cash);
            }
        }
    }
}
