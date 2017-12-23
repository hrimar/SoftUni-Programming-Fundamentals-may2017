using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab06ReverseArrayofStrings
{
    class ReverseArrayofStrings
    {
        static void Main()
        {
            // програма за обръщане на масив в обратен ред:

            // Решение 1:
            //var words = Console.ReadLine().Split(' ').ToArray();

            //for (int i = 0; i < words.Length/2; i++)
            //{
            //    var temp = words[i];
            //    words[i] = words[words.Length-i-1];
            //    words[words.Length - i - 1] = temp;
            //}
            //Console.WriteLine(string.Join(" ", words));

            // Решение 2:
            var words = Console.ReadLine().Split(' ').ToArray();

            Console.WriteLine(string.Join(" ", words.Reverse()));
        }
    }
}
