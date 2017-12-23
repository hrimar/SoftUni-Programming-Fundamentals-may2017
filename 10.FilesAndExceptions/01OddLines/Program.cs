using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01OddLines
{
    class Program
    {
        static void Main()
        {
            //for (int i = 0; i < 1000000; i++)
            //{
            //    Console.Write("\r");
            //    Console.Write("Working 1 of: " + i);
            //}
            int[] arr = new int[] { 1, 3, 5, 7, 8, 6, 4, 2 };
            int[] oddPos = arr.Where((n, index) => index % 2 == 0).ToArray();
            Console.WriteLine(string.Join(" ", oddPos));
        }
    }
}
