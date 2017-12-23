using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab04TripleSum
{
    class TripleSum
    {
        static void Main()
        {           
            var numsArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool existing = false;

            for (int i = 0; i < numsArray.Length; i++)
            {
                for (int j = i+1; j < numsArray.Length; j++) // пуууу трябвало j = i+1 !!!
                {                    
                        int sum = numsArray[i] + numsArray[j];
                        if(numsArray.Contains(sum))
                        {
                            Console.WriteLine($"{numsArray[i]} + {numsArray[j]} == {sum}");
                        existing = true;
                         }                     
                }
            }
            if(!existing)
            {
                Console.WriteLine("No");
            }
        }
    }
}
