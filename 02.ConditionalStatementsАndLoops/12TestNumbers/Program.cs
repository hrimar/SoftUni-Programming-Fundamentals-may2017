using System;

namespace _12TestNumbers
{
    class Program
    {
        static void Main()
        {
            // program, which finds all the possible combinations between two numbers – N and M:
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var sum = int.Parse(Console.ReadLine());
            var multiply = 1;
            var totalSum = 0;
            var combinations = 0;

            for (int i = a; i >=1; i--)
            {
                for (int j = 1; j <= b; j++)
                {
                    multiply=3*(i* j);
                    totalSum += multiply;
                    combinations++;
                    //Console.Write($" {i} {j};");
                    //Console.Write(multiply);

                    if (totalSum>=sum)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {totalSum} >= {sum}");
                        return;
                    }
                }                 
            }
            if (totalSum < sum)
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {totalSum}");
            }
        }
    }
}
