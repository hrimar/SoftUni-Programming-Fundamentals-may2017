using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab07CountNumbers
{
    class Lab07CountNumbers
    {
        static void Main()
        {
            // Решение 1: Сортиране и броене:
            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //    nums.Sort();
            //var counter = 1;

            //for (int i = 1; i < nums.Count; i++)
            //{
            //    if(nums[i]==nums[i-1])
            //    {
            //        counter++;
            //    }
            //    else 
            //    {
            //        Console.WriteLine($"{nums[i-1]} -> {counter}");
            //        counter = 1;
            //    }                
            //}
            //Console.WriteLine($"{nums[nums.Count-1]} -> {counter}");

            // Решение 2: Сортиране и броене с 2 while цикъла!!!: - за пререшаване !!!!
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
             var index = 0;
            var element = nums[index];

            while (index < nums.Count)
            {
                var counter = 1;
                while (nums[index] == (index + counter) && (index + counter) < nums.Count)
              {
                    counter++;
                }
                index = index + counter;
                Console.WriteLine($"{element} -> {counter}");                
            }



            // Решение 3: Dictionary:  за пререшаване !!!!
            //var result = new Dictionary<int, int>();
            //for (int i = 1; i < nums.Count; i++)
            //{
            //    if (nums[i] == nums[i - 1])
            //    {
            //        //result.Index=
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{nums[i - 1]} -> {counter}");
            //        counter = 1;
            //    }
            //}
            //Console.WriteLine($"{nums[nums.Count - 1]} -> {counter}");
        }
    }
}
