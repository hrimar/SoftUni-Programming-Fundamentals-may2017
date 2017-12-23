using System;

namespace Lab05SpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
                  
            for (int i = 1; i <= num; i++)
            {             
               int sum=CalcitatedSumOfDigits(i);

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }

        private static int CalcitatedSumOfDigits(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                var lastDigit = i % 10;
                sum += lastDigit;
                i = i / 10;
            }
            return sum;
        }
    }
}
