using System;

namespace Lab09RefactorSpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int cuirrentNumber = 0;
            bool isSpecial = false;
            for (int ch = 1; ch <= number; ch++)
            {
                cuirrentNumber = ch;
                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{cuirrentNumber} -> {isSpecial}");
                sum = 0;
                ch = cuirrentNumber;
            }
        }
    }
}
