using System;

namespace _05FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(CaculatingFubonaci(n));
        }

        private static long CaculatingFubonaci(long n)
        {
            int a = 0;
            int b = 1;
        
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b;
        }
    }
}
