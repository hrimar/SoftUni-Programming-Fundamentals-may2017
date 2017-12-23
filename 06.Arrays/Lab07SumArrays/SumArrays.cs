using System;
using System.Linq;

namespace Lab07SumArrays
{
    class SumArrays
    {
// 1. Кратко решение, nums1[i % nums1.Length] ни предпазва от превъртане на по-късия масив:
        static void Main()
        {
            var nums1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var nums2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                var result = SumArraysElements(nums1, nums2);
                Console.WriteLine(string.Join(" ", result));       
        }

        private static int[] SumArraysElements(int[] nums1, int[] nums2)
        {
            var longestArrayLength = Math.Max(nums1.Length, nums2.Length);
            var result = new int[longestArrayLength];

            for (int i = 0; i < longestArrayLength; i++)
            {
                result[i] = nums2[i % nums2.Length] + nums1[i % nums1.Length];
            }
     
            return result;
        }
        

// 2. Дълго решение с излишни нови масиви за резултата, но nums1[i % nums1.Length] ни предпазва от превртане на масива:
        //    static void Main()
        //    {
        //        var nums1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //        var nums2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //        var nums1full = new int[nums2.Length];
        //        var nums2full = new int[nums1.Length];

        //        if (nums1.Length < nums2.Length)
        //        {                
        //            for (int i = 0; i < nums2.Length; i++)
        //            {
        //                nums1full[i] = nums1[i % nums1.Length];
        //            }
        //            var result = SumArraysElements(nums1full, nums2);
        //            Console.WriteLine(string.Join(" ", result));
        //        }
        //        else if (nums1.Length > nums2.Length)
        //        {
        //            for (int i = 0; i < nums1.Length; i++)
        //            {
        //                nums2full[i] = nums2[i % nums2.Length]; // !!!
        //            }
        //            var result = SumArraysElements(nums1, nums2full);
        //            Console.WriteLine(string.Join(" ", result));
        //        }
        //        else
        //        {
        //            var result = SumArraysElements(nums1, nums2);
        //            Console.WriteLine(string.Join(" ", result));
        //        }
        //// Ako елем-те са по-малко, се прави нов масив с повтаряне на елем-те на късия!
        //        //Console.WriteLine(0 % 3); -> 0
        //        //Console.WriteLine(1 % 3); -> 1
        //        //Console.WriteLine(2 % 3); -> 2
        //    }

        //    private static int[] SumArraysElements(int[] nums1, int[] nums2)
        //    {
        //        var longestArrayLength = Math.Max(nums1.Length, nums2.Length);
        //        var result = new int[longestArrayLength];

        //        for (int i = 0; i < longestArrayLength; i++)
        //        {
        //            result[i] = nums2[i] + nums1[i];
        //        }
        //        //Console.WriteLine(string.Join(" ", result));
        //        return result;
        //    }
    }
}
