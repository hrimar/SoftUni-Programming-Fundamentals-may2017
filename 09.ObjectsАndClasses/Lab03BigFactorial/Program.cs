using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace Lab03BigFactorial
{   
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            for (int i = 2; i <= n; i++)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);

            //var students = new Dictionary<string, int>();

            //students["Pesho"] = 15;
            //students["Ani"] = 33;

            //Console.WriteLine(string.Join(", ", students.OrderBy(s=>s.Key)));
        }

    }
}
