using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SieveofEratosthenes
{
    class Program
    {
        static void Main()
        {
            // Задача 7* Primes in Given Range - за намиране на прости числа в дипазон:
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            var primes = new bool[n2+1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;           
            }
            primes[0] = primes[1] = false;

            for (int i = 2; i < primes.Length; i++)
            {
                if(!primes[i])
                {
                    continue;
                }
                else
                {
                    if(i>=n1)
                    {
                        Console.Write(i + " ");
                    }                                      
                }
                for (int j = 2 * i; j < primes.Length; j+=i) // !!!
                {
                    primes[j] = false;
                }
            }

            Console.WriteLine();

            // Arrays 4. Sieve of Eratosthenes - намиране на прости числа до n:
            //int n = int.Parse(Console.ReadLine());

            //var primes = new bool[n+1];
            //for (int i = 0; i < primes.Length; i++)
            //{
            //    primes[i] = true;           
            //}
            //primes[0] = primes[1] = false;

            //for (int i = 2; i < primes.Length; i++)
            //{
            //    if(!primes[i])
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.Write(i+" ");                    
            //    }
            //    for (int j = 2 * i; j < primes.Length; j+=i) // !!!
            //    {
            //        primes[j] = false;
            //    }
            //}

            //Console.WriteLine();
        }
    }
}
