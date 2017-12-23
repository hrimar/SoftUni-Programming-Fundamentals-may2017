using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab06SquareNumbers
{
    class IntOrDoubleNum
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();

            foreach (var n in nums)
            {
                // за проверка дали едно число е цяло:
                if(Math.Sqrt(n)%1==0) // или Math.Sqrt(n)==(int)Math.Sqrt(n)
                {
                    result.Add(n);
                }
            }
            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
