using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab06FoldAndSum
{
    class Lab06FoldAndSum
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = nums.Length / 4;
            var leftArray = nums.Take(k).Reverse().ToArray();
            var rightArray = nums.Skip(3*k).Take(k).Reverse().ToArray();

            //var leftAndRightRow1 = new int[2 * k];
            //for (int i = 0; i < k; i++)
            //{
            //    leftAndRightRow1[i] = leftArray[i];
            //}
            //for (int i = 0; i < k; i++)
            //{
            //    leftAndRightRow1[k+i] = rightArray[i];
            //}
            var leftAndRightRow1 = leftArray.Concat(rightArray).ToArray();

            var row2 = nums.Skip(k).Take(2*k).ToArray();
            var sumArray = row2.Select((x, index) => x + leftAndRightRow1[index]); // !!!
            // var sumArray = row2.Zip(leftAndRightRow1, (a, b) => (a+b)); // !!!

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
