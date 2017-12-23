using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab01ReverseString
{
    class Lab01ReverseString
    {
        static void Main()
        {
            // Решение 1:
            var input = Console.ReadLine().ToCharArray();
            var result= new string(input.Reverse().ToArray());
           Console.WriteLine(result);

           

            // Решение 2 с цикъл:
            //var input=Console.ReadLine().ToCharArray();

            //for (int i = 0; i < input.Length/2; i++)
            //{
            //    var temp = input[i];
            //    input[i] = input[input.Length - i-1];
            //    input[input.Length - i-1] = temp;
            //}
            //var result = input.ToString();
            //Console.WriteLine(string.Join("", input));
        }
    }
}
