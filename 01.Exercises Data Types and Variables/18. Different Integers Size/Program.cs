using System;

namespace _18.Different_Integers_Size
{
    public class Program
    {
        public static void Main()
        {
            var n = Console.ReadLine();
            bool canFit = false;
            string message = "";

            try
            {
                sbyte sbyteNum = sbyte.Parse(n);
                message += "* sbyte\n";
                canFit = true;
            }
            catch (Exception)
            {

            }

            try
            {
                byte byteNum = byte.Parse(n);
                message += "* byte\n";
                canFit = true;
            }
            catch (Exception)
            {

            }

            try
            {
                short shortNum = short.Parse(n);
                message += "* short\n";
                canFit = true;
            }
            catch (Exception)
            {

            }

            try
            {
                ushort ushortNum = ushort.Parse(n);
                message += "* ushort\n";
                canFit = true;
            }
            catch (Exception)
            {

            }

            try
            {
                int intNum = int.Parse(n);
                message += "* int\n";
                canFit = true;
            }
            catch (Exception)
            {

            }

            try
            {
                uint uintNum = uint.Parse(n);
                message += "* uint\n";
                canFit = true;
            }
            catch (Exception)
            {

            }

            try
            {
                long longNum = long.Parse(n);
                message += "* long\n";
                canFit = true;
            }
            catch (Exception)
            {

            }

            if (canFit)
            {
                Console.WriteLine("{0} can fit in:", n);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", n);
            }
        }
    }
}
