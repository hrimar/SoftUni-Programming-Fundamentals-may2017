using System;
using System.Collections.Generic;
using System.Linq;

namespace _02AdvertisementMessage
{
    class RandomMessage
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var phrases = new string[]
            {
                "Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product."
            };
            var events = new string[]
           {
               "Now I feel good.", "I have succeeded with this product.",
               "Makes miracles. I am happy of the results!",
               "I cannot believe but now I feel awesome.",
               "Try it yourself, I am very satisfied.", "I feel great!"
           };
            var autor = new string[]
           {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            var cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random r = new Random();


            for (int i = 0; i < n; i++)
            {
                var phraseIndex = r.Next(0, phrases.Length);
                var eventsIndex = r.Next(0, events.Length);
                var autorIndex = r.Next(0, autor.Length);
                var citiesIndex = r.Next(0, cities.Length);

                Console.WriteLine(
                    $"{phrases[phraseIndex]} {events[eventsIndex]} {autor[autorIndex]} - {cities[citiesIndex]}");
            }
    
        }
    }
}
