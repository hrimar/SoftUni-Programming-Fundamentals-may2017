using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab03SumAdjacentEqualNumbers
{
    class Lab03SumAdjacentEqualNumbers
    {
        // бреее тъп ли съм 60/100? Намери решение!!!!
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sum = 0;

            int i = 1;
            while (i < nums.Count)
            {
                    if (nums[i] == nums[i - 1])
                    {
                        sum = nums[i] + nums[i - 1];
                        nums[i - 1] = sum;
                        nums.Remove(nums[i]);                        
                    }
               
                i++;
            }            
            Console.WriteLine(string.Join(" ", nums));

            // Решение:
            //List<double> numbers = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(double.Parse)
            //    .ToList();
            //int i = 0;
            //while (i < numbers.Count - 1)
            //{
            //    if (numbers[i] == numbers[i + 1])
            //    {
            //        numbers[i] += numbers[i + 1];
            //        numbers.RemoveAt(i + 1);
            //        i--;
            //        if (i < 0) i = 0;
            //    }
            //    else i++;
            //}
            //Console.WriteLine(string.Join(" ", numbers));
        }

    }
}
