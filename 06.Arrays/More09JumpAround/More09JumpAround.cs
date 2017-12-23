using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace More09JumpAround
{
    class More09JumpAround
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int curIndex = 0;
            int curElem = 0;
            int prevIndex = 0;// index of nums[0]
            int prevElem = nums[0];          
            int counter = prevElem;

            if(nums[0]>nums.Length)
            {
                Console.WriteLine(nums[0]);
                return;
            }

            while (true)
            {
                curIndex = prevIndex + prevElem;
                
                if(curIndex>=nums.Length)
                {
                    if((prevIndex - prevElem)<0)
                    {
                        break;
                    }
                    curIndex = prevIndex - prevElem;
                    curElem = nums[curIndex];
                }
                else
                {
                    curElem = nums[curIndex];
                }
                counter += curElem;
                prevElem = curElem;
                prevIndex = curIndex;
            }
            Console.WriteLine(counter);
         

        }
    }
}
