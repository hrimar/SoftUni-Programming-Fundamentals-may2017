using System;
using System.Collections.Generic;
using System.Linq;

namespace More01ArrayStatistics
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            double average = 0.0;

            Array.Sort(nums);
            min = nums[0];
            max = nums[nums.Length - 1];
            
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                average = (double)sum / nums.Length;
            }
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
