using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01CountRealNumbers
{
    class Lab01CountRealNumbers
    {
        static void Main()
        {
            var nums     = Console.ReadLine().ToLower().Split(' ').Select(double.Parse).ToArray();
            var result = new SortedDictionary<double, int>(); // Key=word, Value=counter

            foreach (var num in nums)
            {
                if(result.ContainsKey(num))
                {
                    result[num]++;
                }
                else
                {
                    result[num]=1;
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times");
            }
        }
    }
}
