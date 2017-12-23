using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MaxSequencefIncreasingElements
{
    class MaxSequencefIncreasingElements
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            PrinMaxIncreasingElements(nums);
        }

        private static void PrinMaxIncreasingElements(int[] nums)
        {
            var counter = 1;
            var maxCounter = 1;
            var startIndex = 0;
            var startElem = 0;
            var maxStartElem = 0;
            var maxStartIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    counter++;
                    startElem = nums[i] - counter + 1;// разковничето е стартов елемент!!
                    startIndex = i - counter + 1;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxStartElem = startElem;
                        maxStartIndex = startIndex;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = maxStartIndex; i < maxStartIndex + maxCounter; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
