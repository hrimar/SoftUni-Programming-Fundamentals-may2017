using System;
using System.Collections.Generic;
using System.Linq;

namespace _01MaxSequenceОfEqualElements
{
    class Program
    {
        static void Main()
        {
            // Брей, искало съвсем различен подход за Листовете !!!
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            var bestResult = new List<int>();

            result.Add(nums[0]);
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    result.Add(nums[i]);
                }
                else
                {
                    if (result.Count > bestResult.Count)
                    {
                        bestResult = new List<int>(result); //!!!!
                    }
                    result.Clear();
                    result.Add(nums[i]);
                }
                if (result.Count > bestResult.Count)
                {
                    bestResult = new List<int>(result); //!!!!
                }
            }

            Console.WriteLine(string.Join(" ", bestResult));

            // Това решение работеше с Arrays, а сег адава 85/100 ?
            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //int count = 1;
            //int maxCount = 0;
            //int element = 0;
            //int bestElement = 0;

            //for (int i = 1; i < nums.Count; i++)
            //{
            //    element = nums[i - 1];  
            //    if (element == nums[i])
            //    {
            //        count++;
            //        if (count > maxCount)
            //        {
            //            maxCount = count;
            //            bestElement = nums[i]; 
            //        }
            //    }
            //    else
            //    {
            //        count = 1;
            //    }
            //}

            //if (nums.Count == 1)
            //{
            //    Console.WriteLine(nums[0]);
            //}
            //else
            //{
            //    for (int i = 0; i < maxCount; i++)
            //    {
            //        Console.Write(bestElement + " ");
            //    }
            //    Console.WriteLine();
            //}

            // baaasi 85/100 ???????????//
            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //int count = 1;
            //int maxCount = 0;
            //int startIndex = 0;
            //int bestStartIndex = 0;
            //int element = 0;
            //int bestElement = 0;
            //var result = new List<int>();

            //for (int i = 1; i < nums.Count; i++)
            //{
            //    element = nums[startIndex];  // just for info
            //    if (nums[i - 1] == nums[i])
            //    {
            //        count++;
            //        if (count > maxCount)
            //        {
            //            maxCount = count;
            //            bestStartIndex = startIndex;
            //            bestElement = element; // just for info
            //        }
            //    }
            //    else
            //    {
            //        startIndex = startIndex + count;
            //        count = 1;
            //    }

            //    if (maxCount == 1)
            //    {
            //        bestElement=nums[0];
            //    }
            //}

            //    for (int i = 0; i < maxCount; i++)
            //    {
            //        Console.Write(bestElement + " ");
            //      //  Console.Write(nums[i] + " ");
            //    }
            //    Console.WriteLine();

        }
    }
}
