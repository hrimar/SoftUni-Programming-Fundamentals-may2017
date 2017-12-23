using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02SoftUniKaraoke
{
    class Program
    {
        static void Main()
        {
            // 100/100
            var separators = ", ".ToCharArray();
            var result = new Dictionary<string, List<string>>(); // Key=people; Value= song, award
            //var peoples = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
           string[] peoples = Regex.Split(Console.ReadLine(), @"\s*,\s*");  // !!!
            var songs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(a=>a.TrimStart()).ToArray();

            var input = Console.ReadLine();
          
            while (input !="dawn")
            {
                var plaierSong = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.TrimStart()).ToArray();

               string name = plaierSong[0];
               string song = plaierSong[1];
               string award = plaierSong[2];

                if(peoples.Contains(name) && songs.Contains(song))
                {
                    if(!result.ContainsKey(name))
                    {
                        result[name] = new List<string>();
                    }
                    if (!result[name].Contains(award))
                    {
                        result[name].Add(award); // .Distimct!!!     
                    }            
                }

                input = Console.ReadLine();
            }

            if (result.Keys.Count == 0)
                Console.WriteLine("No awards");

            
            foreach (var kvpRes in result.OrderByDescending(a => a.Value.Count))
            {
                Console.WriteLine($"{kvpRes.Key}: {kvpRes.Value.Count} awards");
                foreach (var item in kvpRes.Value.OrderBy(a=>a))
                {
                    Console.WriteLine($"--{item}");
                }
            }


        }
    }
}
