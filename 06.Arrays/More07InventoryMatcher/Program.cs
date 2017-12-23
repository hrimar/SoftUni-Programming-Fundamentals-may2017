using System;
using System.Collections.Generic;
using System.Linq;

namespace More07InventoryMatcher
{
    class Program
    {
        static void Main()
        {
            // оо май я развалих , да взема кода от Judge!
// уж prices трябва да са double, но тогава закръглява 2,540 на 2,54 и става с decimal?!
            var names = Console.ReadLine().Split(' ').ToArray();
            var quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            var nameOrder = Console.ReadLine().Split(' ').ToArray();
            string name = nameOrder[0];

            int quantitiOrder = int.Parse(nameOrder[1]);

            while (nameOrder[0] != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if(nameOrder[0] == names[i])
                    {
                        Console.WriteLine
          ($"{nameOrder} costs: {prices[i]}; Available quantity: {quantities[i]}");
                    }                    
                }
                name = Console.ReadLine();
            }

        }
    }
}
