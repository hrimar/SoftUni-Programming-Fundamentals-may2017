using System;
using System.Collections.Generic;
using System.Linq;

namespace More01OrderbyAge
{
    class People
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Year { get; set; }
    }
    class More01OrderbyAge
    {
        static void Main()
        {
            //Извод: Естествено това може да се реши и с речник, но 
            // с класове няма ограничения за данните, които ще пазим!
            var input = Console.ReadLine();
            var peoplesList = new List<People>();

            while (input != "End")
            {
                var inputDetails = input.Split();
                var name = inputDetails[0];
                var id = (inputDetails[1]);
                var year = int.Parse(inputDetails[2]);

                var people = new People()
                {
                    Name=name,
                    Id=id,
                    Year=year
                };
               
                peoplesList.Add(people);

            peoplesList = peoplesList.OrderBy(s => s.Year).ToList();
                input = Console.ReadLine();
            }
            foreach (var item in peoplesList)
            {
                Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Year} years old.");
            }

        }
    }
}
