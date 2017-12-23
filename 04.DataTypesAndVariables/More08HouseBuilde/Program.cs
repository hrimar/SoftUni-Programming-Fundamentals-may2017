using System;

namespace More08HouseBuilde
{
    class Program
    {
        static void Main()
        {
            int totalSbytes = 0;
            long totalInts = 0;
            for (int i = 0; i < 2; i++)
            {
                string price = Console.ReadLine();

                long intPrice;
                sbyte sbytePrice;
                bool parsed1 = sbyte.TryParse(price, out sbytePrice);
                bool parsed2 = long.TryParse(price, out intPrice);
                if (parsed1)
                {
                    totalSbytes = 4 * sbytePrice;
                }
                else if (parsed2)
                {
                    totalInts = (4 * (intPrice)) + 2 * (3 * intPrice);
                }
            }
            Console.WriteLine(totalInts + totalSbytes);

        }
    }
}
