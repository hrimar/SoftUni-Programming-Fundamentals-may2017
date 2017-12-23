using System;

namespace Lab03LastKNumbersSums
{
    class Program
    {
        static void Main()
        {
            // трака и не и схванах условието на тази задача???
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] nums = new long[n]; // breeee иска масив от long, не от int

            nums[0] = 1;
            
            for (int i = 1; i < nums.Length; i++)
            {
               long sum = 0;
                
                for (int j = i-k; j <= i-1; j++)
                {
                    if (j>=0)
                    {
                        sum+= nums[j];
                    }
                    nums[i] = sum;
                }
            }
            foreach (var num in nums)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();
        }
    }
}
