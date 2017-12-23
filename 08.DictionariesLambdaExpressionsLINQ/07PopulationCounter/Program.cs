using System;
using System.Collections.Generic;
using System.Linq;

namespace _07PopulationCounter
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, Dictionary<string, long>>();

            while (input!="report")
            {
                var countryCityPeoples = input.Split('|').ToArray();
                var city = countryCityPeoples[0];
                var country = countryCityPeoples[1];
                var peoples = long.Parse(countryCityPeoples[2]);

                if(!result.ContainsKey(country))
                {
                    result[country] = new Dictionary<string, long>();
                }
                if(!result[country].ContainsKey(city))
                {
                    result[country][city] = peoples;
                }
                else
                {
                    result[country][city] += peoples;
                }


                input = Console.ReadLine();
            }
           // да се сортират резултатите по бр. жители (низходящ ред)!
            foreach (var countryCity in result.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                var totalPeoples = countryCity.Value.Values.Sum();
                var country = countryCity.Key;

                Console.WriteLine($"{country} (total population: {totalPeoples})");

                foreach (var cityPeople in countryCity.Value.OrderByDescending(x=>x.Value))
                {
                    var city = cityPeople.Key;
                    var peoples = cityPeople.Value;
                  
                   
                    Console.WriteLine($"=>{city}: {peoples}");
                }
            }

        }
    }
}
