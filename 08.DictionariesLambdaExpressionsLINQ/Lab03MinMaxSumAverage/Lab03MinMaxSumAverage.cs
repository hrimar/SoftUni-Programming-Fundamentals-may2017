using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab03MinMaxSumAverage
{
    class Lab03MinMaxSumAverage
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var nums = new List<int>();
            for (int i = 0; i < n; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));
            }

            int sum = nums.Sum();
            int min = nums.Min();
            int max = nums.Max();
            double average = nums.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
