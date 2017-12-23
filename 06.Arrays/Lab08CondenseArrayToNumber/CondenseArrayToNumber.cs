using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab08CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;        
         
            while (nums.Length>1)
            {
                var newNums = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    newNums[i] = nums[i] + nums[i + 1];
                }
                nums = newNums; // един масив става равен на друг !!!!!! ЧЕТИ ОЩЕ ЗА ТОВА!
            }
            if (nums.Length < 2)
            {
                sum = nums[0];
            }
            Console.WriteLine(sum);
        }
    }
}
