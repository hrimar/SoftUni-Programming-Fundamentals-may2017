using System;

namespace _06IntervalOfNumbers
{
    class Program
    {
        static void Main()
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());

            var temp = 0;

            if(n1>n2)
            {
                temp = n1;
                n1 = n2;
                n2 = temp;
            }
            for (int i = n1 ; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
