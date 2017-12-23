using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _02ConvertfromBase_NtoBase_10
{
    class ConvertfromBase_NtoBase_10
    {
        static void Main()
        {
            //80/100:
            var number = Console.ReadLine().Split();
            var baseN = int.Parse(number[0]);
            var num = number[1].Reverse().ToArray();
            var sum = new BigInteger();

            for (int i =0; i < num.Length; i++)
            {
                var digit = int.Parse(num[i].ToString());
                
              sum += digit * (BigInteger)Math.Pow(baseN, i);
                
            }
            Console.WriteLine(sum);

            // товае за обръщане от 10101 в десетична със стрингове:
            //var n = Console.ReadLine().ToCharArray();
            //var res = 0.0;

            //for (int i = n.Length-1; i >=0; i--)
            //{
            //    var digit = n[i];
            //    char one = '1';
            //    if (digit == one)
            //    {
            //        res += 1 * Math.Pow(2.0, n.Length - 1-i);
            //    }
            //    else
            //    {
            //        res += 0 * Math.Pow(2.0, n.Length - 1-i);
            //    }
            //}
            //Console.WriteLine(res);
        }
    }
}
