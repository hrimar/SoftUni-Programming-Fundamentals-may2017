using System;
using System.Collections.Generic;
using System.Numerics;

namespace _13Factorial
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel =GetFactoriel(n);
        
            Console.WriteLine(factoriel);
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
