using System;

namespace Lab03ExactSumOfRealNumbers
{
    class Program
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 0; i < n; i++)
            {
               decimal num = decimal.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
