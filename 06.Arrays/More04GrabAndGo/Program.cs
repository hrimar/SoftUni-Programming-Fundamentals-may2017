using System;
using System.Linq;
using System.Collections.Generic;

namespace More04GrabAndGo
{
    class Program
    {
        static void Main()
        {
            // bre 85/100 ???
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            var result = new List<int>();
                       
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]==n)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sum += nums[j];
                    }
                    result.Add(sum);                 
                }
                else
                {
                    sum = 0;
                }
            }
            if(result.Count==0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(result[result.Count - 1]);
            }
     
        }
    }
}
