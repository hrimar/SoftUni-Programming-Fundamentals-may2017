using System;
using System.Collections.Generic;
using System.Linq;

namespace _07BombNumbers
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var special = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var specNumber = special[0];
            var specPower = special[1];
            var index = 0;          

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i]==specNumber)
      // if (nums.Contains(specNumber))  ->   index = nums.IndexOf(specNumber);
                {
                    index = i;
                    
                    var leftIndex = index - specPower;
                    var rightIndex = index + specPower;

                    var sureLeftIndex = Math.Max(0, leftIndex);
                    var sureRightIndex = Math.Min(nums.Count - 1, rightIndex);
                    var countForDelete = sureRightIndex - sureLeftIndex + 1;

                    nums.RemoveRange(sureLeftIndex, countForDelete);

                    i = -1;
                } 
            }          
            Console.WriteLine(nums.Sum());
            

            // така 60/100 Абе друг е подхода - да махам елементи от leftIndex до rightIndex!!!
            // Реши я ПАК по другия начин!!!!!
            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //var special = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //var specNumber = special[0];
            //var specPower = special[1];
            //var index = 0;
            //var result = new List<int>();

            //    for (int i = 0; i < nums.Count; i++)
            //    {

            //    if (nums.Contains(specNumber))
            //        {
            //            index = nums.IndexOf(specNumber);


            //        var leftIndex = index - specPower;
            //        var rightIndex = index + specPower;

            //            if (i < Math.Max(0, leftIndex) || i > Math.Min(nums.Count-1, rightIndex))
            //            {
            //                result.Add(nums[i]);
            //            }
            //        }

            //    }          

            //int sum=result.Sum();
            ////Console.WriteLine(string.Join(" ", result));
            //Console.WriteLine(sum);
        }
    }
}
