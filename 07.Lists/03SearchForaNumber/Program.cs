using System;
using System.Collections.Generic;
using System.Linq;

namespace _03SearchForaNumber
{
    class Program
    {
        static void Main()
        {
            //странно 33/100 ???????????
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var special = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();

            var take = special[0];
            for (int i = 0; i < take; i++)
            {
                result.Add(nums[i]);
            }

            var delete = special[1];
            for (int i = 0; i < delete; i++)
            {
                result.RemoveAt(i);
            }
            var yesOrNo = special[2];

            if (yesOrNo==result.Count)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
