using System;
using System.Numerics;

namespace _14FactorialTrailingZeroes
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = GetFactoriel(n);

            //int counter = 0;
            //BigInteger lastDigit = factoriel % 10;

            //while (lastDigit == 0)
            //{
            //    if (lastDigit == 0)
            //    {
            //        counter++;
            //    }
            //    factoriel = factoriel / 10;
            //   lastDigit = factoriel % 10;
            //}

            int counter = GetLastZeroes(factoriel);
            // Console.WriteLine(factoriel);
            Console.WriteLine(counter);
        }

        private static int GetLastZeroes(BigInteger factoriel)
        {
            int counter = 0;
            BigInteger lastDigit = factoriel % 10;

            while (lastDigit == 0)
            {
                if (lastDigit == 0)
                {
                    counter++;
                }
                factoriel = factoriel / 10;
                lastDigit = factoriel % 10;
            }
            return counter;
        }

        private static BigInteger GetFactoriel(int n)
        {
            BigInteger factoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }
            return factoriel;

        }
    }
}
