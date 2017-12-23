using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02RotateandSum
{
    class RotateandSum
    {
        static void Main()
        {
            // разгеле! виж я пак!
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k=int.Parse(Console.ReadLine());

            var newNums = new int[nums.Length];
            var sum = new int[nums.Length];

            for (int i = 1; i <= k; i++)
            {
                for (int j = 0; j < nums.Length; j++)//за да сумиране след всяко завъртане
                {
                     newNums[(j+i) % nums.Length]= nums[j]; // !!!
// въртенето моxе да стане и като изведем lastElem, преместим напред elements и nums[0]=lastElem!
                    sum[(j + i) % nums.Length] += newNums[(j + i) % nums.Length];                }
            }
            //Console.WriteLine(string.Join(" ", newNums));
            Console.WriteLine(string.Join(" ", sum));
            //Console.WriteLine(0%3); - 0
            //Console.WriteLine(1%3); - 1 
            //Console.WriteLine(2%3); - 2
            //Console.WriteLine(3%3); - 0
            //Console.WriteLine(4%3); - 1 
        }
    }
}
