using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab09ExtractMiddleElements
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            if(nums.Length==1)
            {
                int element1 = nums[0];
                Console.WriteLine("{ "+$"{element1}" + " }");
            }
            else if (nums.Length > 1 && nums.Length%2==0)
            {
               int element1 = nums[nums.Length / 2 - 1];
                int element2 = nums[nums.Length / 2];
                Console.WriteLine("{ " + $"{element1}, {element2}" + " }");
            }
            else if (nums.Length > 1 && nums.Length % 2 == 1)
            {
                int element1 = nums[nums.Length / 2 - 1];
                int element2 = nums[nums.Length / 2];
                int element3 = nums[nums.Length / 2 + 1];
                Console.WriteLine("{ " + $"{element1}, {element2}, {element3}" + " }");
            }

        }
    }
}
