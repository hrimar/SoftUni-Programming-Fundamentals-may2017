using System;

namespace _02MaxMethod
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            int max = 0;

            if(a>b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(a, b), c));
        }
    }
}
