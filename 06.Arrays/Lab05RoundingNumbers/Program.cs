using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab05RoundingNumbers
{
    class Program
    {
        static void Main()
        {
            var numsArray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var result = new double[numsArray.Length];

            for (int i = 0; i < numsArray.Length; i++)
            {
                result[i] =(numsArray[i]);
            }
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine($"{numsArray[i]} => {result[i]:0}");
            }
            //Console.WriteLine(Math.Round(2.5)); -> 2
            //Console.WriteLine($"{2.5:0}");      -> 3
            //Console.WriteLine(Math.Ceiling(2.5)); -> 3
        }
    }
}
