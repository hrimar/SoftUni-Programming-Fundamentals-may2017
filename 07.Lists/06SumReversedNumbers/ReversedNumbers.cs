using System;
using System.Collections.Generic;
using System.Linq;

namespace _06SumReversedNumbers
{
    class ReversedNumbers
    {
        static void Main()
        {
            // Решение 1 - със обръщане в стринг, чар масив, той пак в нов стринг и int:
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sum = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                var reversedCharArray = nums[i].ToString().Reverse().ToArray();
                var reversedString = new string(reversedCharArray);
                var reversedNums = int.Parse(reversedString);
              
                sum += reversedNums;
            }
            Console.WriteLine(sum);


            // Мое решение само с интегерс:
            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //var sum = 0;                     

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    //int reverse = GetReversedNum(nums, i);
            //    sum += reverse;
            //}
            //Console.WriteLine(sum);
        }

        //private static int GetReversedNum(List<int> nums, int i)
        //{
        //    int reverse = 0;
        //    while (nums[i] > 0)
        //    {
        //        int lastDigit = nums[i] % 10;
        //        reverse = (reverse * 10) + lastDigit;
        //        nums[i] = nums[i] / 10;
        //    }

        //    return reverse;
        //}
    }
}
