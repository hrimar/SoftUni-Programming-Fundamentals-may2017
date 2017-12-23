using System;
using System.Collections.Generic;

namespace _07PrimesinGivenRange
{
    class Program
    {

        private static bool[] CreatingPrimesArray(int n2)
        {
            var primes = new bool[n2 + 1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;
            return primes;
        }

        private static List<int> PrintingPrimes(int n1, bool[] primes)
        {
            var onlyPrimes = new List<int>();

            for (int i = 2; i < primes.Length; i++)
            {
                if (!primes[i])
                {
                    continue;
                }
                else
                {
                    if (i >= n1)
                    {
                        //Console.Write(i + " ");
                        onlyPrimes.Add(i);
                    }
                }
                for (int j = 2 * i; j < primes.Length; j += i) // !!!
                {
                    primes[j] = false;
                }
            }

            return onlyPrimes;
        }

        static void Main()
        {
            // Задача 7* Primes in Given Range - за намиране на прости числа в дипазон:
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            bool[] primes = CreatingPrimesArray(n2);

             PrintingPrimes(n1, primes);
           
            Console.WriteLine(string.Join(", ", PrintingPrimes(n1, primes)));

    // Това решение не работо - според предната програма 10 е просто и това ми бърка тази програма
            //    long n1 = long.Parse(Console.ReadLine());
            //    long n2 = long.Parse(Console.ReadLine());

            //    string primes = string.Empty;

            //    for (long n = n1; n <= n2; n++)
            //    {
            //        if (CheckPrime(n))
            //        {
            //            primes += n + ", ";
            //        }
            //    }
            //    if (primes[primes.Length - 1] == ',')
            //        primes = primes.Remove(primes.Length - 1);
            //    else if (primes[primes.Length - 1] == ' ')
            //        primes = primes.Remove(primes.Length - 2);
            //    Console.WriteLine(string.Join(" ", primes));
            //}

            //private static bool CheckPrime(long n)
            //{
            //    if (n <= 1)
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        for (int i = 2; i <= (int)Math.Sqrt(n); i++) // Мале, искало (int) ?!?
            //        {
            //            if (n % (int)Math.Sqrt(n) == 0)
            //            {
            //                return false;
            //            }
            //        }

            //    }
            //    return true;
        }

    }
}