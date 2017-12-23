using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SumBigNumbers
{
    class Program
    {
        static void Main()
        {
            //male...
          var str1 = Console.ReadLine().ToArray();
          var str2 = Console.ReadLine().ToArray();
            //var str3 = new int[Math.Max(str1.Length, str2.Length)];
            var str3 = string.Empty;
            var shortStr = Math.Min(str1.Length, str2.Length);

            //var rest = 0;
            
            //for (int i = shortStr-1; i >=0; i--)
            //{
            //   str3+=(int.Parse(str1[i].ToString()) + int.Parse(str2[i].ToString()));

            //    if (str3[i] > 9)
            //    {
            //        str3[i] = str3[i] % 10;
            //        str3[i + 1]++;
            //    }
            //}

            Console.WriteLine(str3);
        }
    }
}
