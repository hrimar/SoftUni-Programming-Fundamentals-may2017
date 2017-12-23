using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08LettersChangeNumbers
{
    class Program
    {
        static void Main()
        {
            var str = Console.ReadLine().Split(new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries).ToArray(); // !!! /t !!!
            var sum = 0.0;
            //var abc = new char[26]; // просто от аски кода -97
            //for (int i = 0; i < 26; i++)
            //{
            //    abc[i] = (char)(i + 97);
            //}

            foreach (var item in str)
            {
                var first = item.First();
                var last = item.Last();
                var num2 = item.Substring(1, item.Length - 2);
                var number = double.Parse(num2);

                if (char.IsUpper(first))
                {
                    number /= (first - ('A' - 1));
                }
                else
                {
                    number*= (first - ('a' - 1));
                }
                if (char.IsUpper(last))
                {
                    number-= (last - ('A' - 1));
                }
                else
                {
                    number += (last - ('a' - 1));
                }
                sum += number;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
