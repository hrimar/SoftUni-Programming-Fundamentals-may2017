using System;

namespace _13GameOfNumbers
{
    class Program
    {
        static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var magic = int.Parse(Console.ReadLine());
            var combinations=0;
            var lastA = 0;
            var lastB = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    combinations++;
                    if (i + j == magic)
                    {
                        lastA = i;
                        lastB = j;                        
                    }                    
                }
            }
            if(lastA==0 || lastB==0)
            {
                  Console.WriteLine($"{combinations} combinations - neither equals {magic}");
            }
            else
            {
                Console.WriteLine($"Number found! {lastA} + {lastB} = {lastB+lastA}");
            }
        }
    }
}
