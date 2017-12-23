using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08MultiplyEvensByOdds
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int result=GetMultopluieEvensAndOdds(n);
            Console.WriteLine(result);
        }

        private static int GetMultopluieEvensAndOdds(int n)
        {
            int sumEven = GetSumEvenDidits(n);
            int sumOdds= GetSukOddDigits(n);
            return sumEven * sumOdds;
        }

        private static int GetSukOddDigits(int n)
        {
            int currentDigit = 0;
            int sum = 0;
            while (Math.Abs(n) > 0)
            {
                currentDigit = n % 10;
                n = n / 10;

                if (Math.Abs(currentDigit) % 2 == 1) // odd: -9%2 = -1 !!!
                {
                    sum += Math.Abs(currentDigit);
                }
            }
            return Math.Abs(sum);
        }

        private static int GetSumEvenDidits(int n)
        {
            int currentDigit = 0;
            int sum = 0;
            while (Math.Abs(n) > 0)
            {
                currentDigit = n % 10;
                n = n / 10;
                
                if(currentDigit%2==0) //even
                {
                    sum += currentDigit;
                }
            }
            return Math.Abs(sum);
        }
    }
}
