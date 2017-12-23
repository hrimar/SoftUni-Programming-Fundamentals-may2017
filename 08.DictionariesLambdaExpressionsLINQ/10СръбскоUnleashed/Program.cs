using System;
using System.Collections.Generic;
using System.Linq;

namespace _10СръбскоUnleashed
{
    class Program
    {
        static void Main()
        {
            //довърши ако има невалиден вход!
            var namePlaceMoney = new Dictionary<string, Dictionary<string, decimal>> ();
         
            var input = Console.ReadLine();

            while (input!="End")
            {

                var namePlacePrice = input.Split('@');
                var name = namePlacePrice[0].Trim();
                var placePrice = namePlacePrice[1].Split();
                var place = string.Empty;
                for (int i = 0; i < placePrice.Length-2; i++)
                {
                    place += placePrice[i] + " ";
                }
                place = place.Trim();
                var ticketPrice = 0.0m;
                try
                {
ticketPrice = decimal.Parse(placePrice[placePrice.Length - 2]);
                }
                catch (Exception)
                {

                    continue;
                }
                 
                var tiketCount = decimal.Parse(placePrice.Last());

              
                if (!namePlaceMoney.ContainsKey(place))
                {
                    namePlaceMoney[place] = new Dictionary<string, decimal>();
                }
                if (!namePlaceMoney[place].ContainsKey(name))
                {
                    namePlaceMoney[place][name] = ticketPrice * tiketCount;
                }
                else
                {
                    namePlaceMoney[place][name] += ticketPrice * tiketCount;
                }

                input = Console.ReadLine();
                
            }
            foreach (var namePlace in namePlaceMoney)
            {
                var place = namePlace.Key;
                Console.WriteLine($"{place}");
                foreach (var placeMoney in namePlace.Value.OrderByDescending(a=>a.Value))
                {

                    Console.WriteLine($"#  {placeMoney.Key} -> {placeMoney.Value}");
                }
            }
        }
    }
}
