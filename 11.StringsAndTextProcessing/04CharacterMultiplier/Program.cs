using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CharacterMultiplier
{
    class Program
    {
        static void Main()
        {
//100/100 - ok
            var str = Console.ReadLine().Split();
            var str1 = str[0];
            var str2 = str[1];
            var count = 0;

            for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
            {                
                    count+=(int)str1[i] * (int)str2[i];                
            }
            if(str1.Length > str2.Length)
            {
                var rest = Math.Max(str1.Length, str2.Length) - Math.Min(str1.Length, str2.Length);
                var restString = str1.Substring(str2.Length, rest);
                for (int i = 0; i < rest; i++)
                {
                    count += (int)restString[i];
                }
            }
            else if (str1.Length < str2.Length)
            {
                var rest = Math.Max(str1.Length, str2.Length) - Math.Min(str1.Length, str2.Length);
                var restString = str2.Substring(str1.Length, rest);
                for (int i = 0; i < rest; i++)
                {
                    count += (int)restString[i];
                }
            }
            Console.WriteLine(count);
        }
    }
}
