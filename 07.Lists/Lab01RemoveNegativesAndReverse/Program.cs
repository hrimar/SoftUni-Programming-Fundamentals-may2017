using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01RemoveNegativesAndReverse
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();

            foreach (var n in nums)
            {
                if (n >= 0)
                {
                    result.Add(n);
                }               
            }

            result.Reverse();
            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
