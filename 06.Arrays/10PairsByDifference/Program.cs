using System;
using System.Linq;


namespace _10PairsByDifference
{
    class Program
    {
        static void Main()
        {
            // 1. Мое решение 100/100:
            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int n = int.Parse(Console.ReadLine());
            //var counter = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i; j < nums.Length; j++) // Ако j=0 прави излишни броенета!
            //    {                   
            //      if(Math.Abs(nums[i]-nums[j])==n)
            //        {
            //            counter++;
            //        }
            //    }
            //}           
            //  Console.WriteLine(counter);


            // 2. Хитро решение с forach:      
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var diff = int.Parse(Console.ReadLine());
            var count = 0;

            foreach (var num in nums)
            {
                foreach (var nu in nums)
                {
                    if (num - nu == diff)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
