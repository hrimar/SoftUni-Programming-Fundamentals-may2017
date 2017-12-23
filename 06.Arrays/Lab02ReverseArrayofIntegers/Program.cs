using System;

namespace Lab02ReverseArrayofIntegers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] integers = new int[n];

            for (int i = 0; i < n; i++)
            {
                integers[i]= int.Parse(Console.ReadLine());                
            }

            for (int i = 0; i < integers.Length; i++) // или обратен цикъл от n
            {
                Console.Write(integers[integers.Length - i-1]+" ");
            }
            Console.WriteLine();
        }
    }
}
