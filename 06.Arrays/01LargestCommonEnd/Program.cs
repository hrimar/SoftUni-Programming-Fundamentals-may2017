using System;
using System.Collections.Generic;
using System.Linq;

namespace _01LargestCommonEnd
{
    class Program
    {
        static void Main()
        {
            var words1 = Console.ReadLine().Split(' ').ToArray();
            var words2 = Console.ReadLine().Split(' ').ToArray();

            var leftCounter = 0;
            var rightCounter = 0;

            var leftString = string.Empty; // даже са излишни стринговете с намерени думи
            var rightString = string.Empty;

            var shortestArray = Math.Min(words1.Length, words2.Length);// Taka e po-dobre

            for (int i = 0; i < shortestArray; i++)
            {
                if(words1[i]==words2[i])
                {
                    leftCounter++;
                    leftString += words1[i] + " ";
                }
            }
            for (int i = 0; i < shortestArray; i++)
            {
                if (words1[words1.Length - i-1] == words2[words2.Length - i-1])
                {
                    rightCounter++;
                    rightString += words1[words1.Length - i-1] + " ";
                }
            }

            // Това е излишно много код, прото ползвай Math.Max():
            //if (leftCounter >= rightCounter)
            //{
            //    //Console.WriteLine(leftString);
            //    Console.WriteLine(leftCounter);
            //}
            //else if (leftCounter < rightCounter)
            //{
            //   // Console.WriteLine(rightString);
            //    Console.WriteLine(rightCounter);
            //}
            //else if(leftCounter==0 && rightCounter==0)
            //{
            //    Console.WriteLine(leftCounter);
            //}
            Console.WriteLine(Math.Max(leftCounter, rightCounter));
        }

    }
}
