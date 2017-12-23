using System;
using System.Collections.Generic;
using System.Linq;

namespace More02OddFilter
{
    class OddFilter
    {
        static void Main()
        {
            // 1.
            var evenNums = Console.ReadLine().Split().Select(int.Parse).Where(n => n % 2 == 0).ToArray();
            var average = evenNums.Average();
             var result = evenNums.Select(n=>n>average ? ++n : --n ); 
            
            Console.WriteLine(string.Join(" ", result));

            // 2.
            //var evenNums = Console.ReadLine().Split().Select(int.Parse).Where(n=>n%2==0).ToArray();
            //var average = evenNums.Average();
            //// var result = evenNums.Select(n=>n>average==n+1); 
            //// ??? kak да съкратя това долното ???
            //for (int i = 0; i < evenNums.Length; i++)            
            //{
            //    if(evenNums[i]>average)
            //    {
            //        evenNums[i]++;
            //    }
            //    else 
            //    {
            //        evenNums[i]--;
            //    }

            //}
            //Console.WriteLine(string.Join(" ", evenNums));

        }
    }
}
