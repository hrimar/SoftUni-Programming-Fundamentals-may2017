using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab02OddOccurrences
{
    class Lab02OddOccurrences
    {
        static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(' ').ToArray();
            var result = new Dictionary<string, int>(); // Key=word, Value=counter
            var resultList = new List<string>();

            foreach (var word in words)
            {
                if(!result.ContainsKey(word))
                {
                    result[word] = 1;
                }
                else
                {
                    result[word]++;
                }
            }

            foreach (var res in result.Keys)
            {
                if(result[res]%2==1)// == if(res.Value % 2 == 1)
                {
                    resultList.Add(res);
                }
            }
            Console.WriteLine(string.Join(", ", resultList));

            // За принтиране на всяка дума колко пъти се среща!!!:
            foreach (var res in result)
            {
                Console.WriteLine(res.Key+" -> "+res.Value);
            }
        }
    }
}
