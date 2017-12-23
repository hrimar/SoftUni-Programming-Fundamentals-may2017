using System;

namespace Lab08SumOfOddNumbers
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1, j=1; i <= n; i++, j+=2)
            {
                Console.WriteLine(j);
                sum += j;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
