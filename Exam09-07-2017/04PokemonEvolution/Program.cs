using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04PokemonEvolution
{
        class Program
    {
        static void Main()
        {
            // Извод: Тази задача не може да се реши така с Речник в Речник, защото:
            // - втория речник не позволява да се повтарят клщчовете, а то трябва, 
            // затова решението е с Dictionary<string, List<Evolutions>>() !!!!
            var nameTypeIndex = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "wubbalubbadubdub")
                    break;

                var details = Regex.Split(input, @"\s*->\s*");
                var name = details[0];
                if (details.Length == 1)
                {

                    Console.WriteLine($"# {name}");
                    foreach (var item in nameTypeIndex[name])
                    {
                        Console.WriteLine($"{item.Key} <-> {item.Value}");

                    }

                }
                else
                {
                    var type = details[1];
                    var index = int.Parse(details[2]);

                    if (!nameTypeIndex.ContainsKey(name))
                    {
                        nameTypeIndex[name] = new Dictionary<string, int>();
                    }
                    nameTypeIndex[name][type] = index;

                }
            }
            foreach (var res in nameTypeIndex)
            {
                Console.WriteLine($"# {res.Key}");
                foreach (var item in res.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"{item.Key} <-> {item.Value}");
                }
            }

            //var input = Console.ReadLine();
            //var result = new Dictionary<string, List<string>>();

            //while (input != "wubbalubbadubdub")
            //{

            //    var details = Regex.Split(input, @"\s*->\s*");
            //    var name = details[0];
            //    if (details.Length == 1)
            //    {

            //        Console.WriteLine($"# {name}");
            //        foreach (var item in result[name])
            //        {
            //            Console.WriteLine($"{item}");
            //        }

            //    }
            //    else
            //    {

            //        var type = details[1];
            //        var index = int.Parse(details[2]);

            //        //var pokemon= new Pokemon
            //        //{
            //        //    Type=type,
            //        //    Index=index
            //        //};
            //        if (!result.ContainsKey(name))
            //        {
            //            result[name] = new List<string>();
            //            //result[name] = pokemon;
            //        }
            //        string pokemonDetails = $"{type} <-> {index}";
            //        result[name].Add(pokemonDetails);
            //    }

            //    input = Console.ReadLine();
            //}

            //foreach (var res in result)
            //{
            //    var index=res.Value.Split()
            //}


            //foreach (var res in result) // Така не става сорта:  result.OrderByDescending(a=>a.Value)
            //{
            //    Console.WriteLine($"# {res.Key}");
            //    foreach (var item in res.Value)
            //    {
            //        Console.WriteLine($"{item}");
            //    }
            //}

        }
    }
}
