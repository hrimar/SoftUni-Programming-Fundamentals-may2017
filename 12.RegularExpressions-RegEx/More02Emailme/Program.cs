using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace More02Emailme
{
    class Program
    {
        static void Main()
        {
            // 83/100
            var input = Console.ReadLine().Split('@').ToArray();
            var before = input[0];
            var after = input[1];
            var sumBefore = CalcSum(before);
            var sumAfter = CalcSum(after);
            var subtract = sumAfter - sumBefore;

            if(subtract<0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }

        private static int CalcSum(string before)
        {
            var sum = 0;
            for (int i = 0; i < before.Length; i++)
            {
                sum += (int)(before[i]);
            }
            return sum;
        }
    }
}
