﻿using System;

namespace _10TriangleOfNumbers
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        
        }
    }
}
