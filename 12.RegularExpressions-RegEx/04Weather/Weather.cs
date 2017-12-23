using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04Weather
{
    class Weather
    {
        static void Main()
        {
            // Решение 1 с клас - класа се слага като стс-ст в Речника!
            //var cityWether = new Dictionary<string, City>();

            // Решение 2:
            var cityWether = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var regex = new Regex(@"(?<city>[A-Z]{2})(?<temperature>\d+\.\d*)(?<wether>[A-Za-z]+)\|");
                var mached = regex.Match(input);

                bool isMatched = regex.IsMatch(input);
                if (isMatched) // или if(mached.Success)
                {
                    var name = mached.Groups["city"].Value;
                    var temperature = double.Parse(mached.Groups["temperature"].Value);
                    var wether = mached.Groups["wether"].Value;
                    City city = new City()
                    {
                        Name = name,
                        Temperature = temperature,
                        Wether = wether
                    };


                    if (!cityWether.ContainsKey(mached.Groups["city"].Value))
                    {
                        cityWether[name] = string.Empty;
                    }
                    cityWether[name] = $"{temperature} => {wether}";
                }
            }
            foreach (var item in cityWether.OrderBy(a=>a.Value))
            {
                Console.WriteLine($"{item.Key} => {item.Value:f2}");
            }

        }
        class City
        {
            public string Name { get; set; }
            public double Temperature { get; set; }
             public string Wether { get; set; }
        }
    }
}
