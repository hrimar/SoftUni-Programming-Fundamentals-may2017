using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab05SortNumbers
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            nums.Sort();

            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}
