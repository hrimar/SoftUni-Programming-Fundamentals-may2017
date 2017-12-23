using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab02AppendLists
{
    class Lab02AppendLists
    {
        static void Main()
        {
            //бреее просто искало друг подход!!!

            var nums = Console.ReadLine().Split('|').ToList();
            var result = string.Empty;

            for (int i = nums.Count-1; i >=0; i--)
            {
                result+=(nums[i]+" ");
            }
         
            var finalArray= result
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.WriteLine(string.Join(" ", finalArray));
        }
    }
}
