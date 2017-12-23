using System;
using System.Collections.Generic;
using System.Linq;

namespace _03FoldandSum
{
    class FoldAndSum
    {
        static void Main()
        {
            // 1. Мое решение: 100/100
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = new int[nums.Length / 2];

            for (int i = 0; i < nums.Length / 4; i++)
            {
                result[i] = (nums[nums.Length / 4 - 1 - i] + nums[i + nums.Length / 4]);
            }
            for (int i = 0; i < nums.Length / 4; i++)
            {
                result[result.Length / 2 + i] = (nums[nums.Length - i - 1] + nums[(i + nums.Length / 2)]);
            }

            Console.WriteLine(string.Join(" ", result));

            // 2. друго решение с 4 нови масива:


            // 3. с lambda и LINQ
            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int k = nums.Length / 4;

            //var rowLeft = nums.Take(k).Reverse();
            //var rowRight = nums.Reverse().Take(k);
            //var row1 = rowLeft.Concat(rowRight).ToArray();
            //var row2 = nums.Skip(k).Take(2 * k).ToArray();
            //var sumnums = row1.Select((x, index) => x + row2[index]);

            //Console.WriteLine(string.Join(" ", sumnums));
        }
    }
}
