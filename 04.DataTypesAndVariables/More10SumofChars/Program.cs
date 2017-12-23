using System;

namespace More10SumofChars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                totalSum += (int)letter;
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
