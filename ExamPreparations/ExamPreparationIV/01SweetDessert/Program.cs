using System;
using System.Collections.Generic;
using System.Linq;

namespace _01SweetDessert
{
    class Program
    {
        static void Main()
        {
            var ivansMoney = decimal.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var oneBanan = decimal.Parse(Console.ReadLine());//
            var oneEgg = decimal.Parse(Console.ReadLine());//
            var kgBerries = decimal.Parse(Console.ReadLine());

            decimal portions = Math.Ceiling((decimal)guests / 6.0m);//Math.Ceiling
            decimal neededBananas = 2.0m * oneBanan;
            decimal neededEggs = 4.0m * oneEgg;
            decimal neededBerries = 0.2m * kgBerries;
            var neededProductsPrice = portions * neededBananas + portions * neededEggs + portions * neededBerries;

            if (neededProductsPrice <= ivansMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededProductsPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededProductsPrice - ivansMoney:f2}lv more.");
            }
        }
       }
}
