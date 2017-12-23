using System;
using System.Collections.Generic;
using System.Linq;

namespace _06MaxSequenceОfEqualElements
{
    class MaxSequenceОfEqualElements
    {
        static void Main()
        {
            // 1. Мое решение 100/100:        
            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
             //var counter = 1;
            //var maxCounter = 1;
            //int current = 0;
            //int repeatedDigit = 0;

            //for (int i = 1; i < nums.Length; i++)
            //{
            //    current = nums[i - 1];
            //    if (nums[i] == current)
            //    {
            //        counter++;
            //        if (counter > maxCounter)
            //        {
            //            maxCounter = counter;
            //            repeatedDigit = nums[i];
            //        }                                      
            //    }
            //    else
            //    {
            //        counter = 1;
            //    }
            //}
            //for (int i = 0; i < maxCounter; i++)
            //{
            //    Console.Write(repeatedDigit + " ");
            //}
            //Console.WriteLine();


            // 2. Авторско решение с вземане на индекса на 1-вия елемент от еднаквите:
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var counter = 1;
            var maxCounter = 1;
            int startIndex = 0;
            int maxStartIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxStartIndex = startIndex;
                    }
                }
                else
                {
                    counter = 1;
                    startIndex = i;
                }
            }
            for (int i = maxStartIndex; i < maxStartIndex+maxCounter; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
