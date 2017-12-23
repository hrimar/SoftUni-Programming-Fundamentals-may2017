using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Largest3Numbers
{
    class Lab04Largest3Numbers
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().
                Select(int.Parse).OrderBy(n => -n).Take(3).ToArray();
            
            // .OrderBy(n => -n)  <==>  OrderByDecending(n => n)  !!!

            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
