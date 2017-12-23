using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab04Palindromes
{
    class Lab04Palindromesam
    {
        static void Main()
        {
            // Мое дълго решение:
            //var separators = ",. !?".ToCharArray();
            //var text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            //var ok = 0;
            //var result = new List<string>();
            //foreach (var item in text)
            //{
            //    if (item.Length % 2 == 0)
            //    {
            //        var str1 = item.Substring(0, item.Length / 2);
            //        var str2 = (item.Substring(item.Length / 2));
            //        var str2Rev = str2.ToCharArray();
            //        var str2R = new string(str2Rev.Reverse().ToArray());
            //        if ((str1) == str2R)
            //        {
            //            result.Add(item);
            //        }
            //    }
            //    else if (item.Length % 2 == 1)
            //    {
            //        var str1 = item.Substring(0, item.Length / 2);
            //        var str2 = (item.Substring(item.Length / 2 + 1));
            //        var str2Rev = str2.ToCharArray();
            //        var str2R = new string(str2Rev.Reverse().ToArray());
            //        if ((str1) == str2R)
            //        {
            //            result.Add(item);
            //        }
            //    }
            //}  
            //    Console.WriteLine(string.Join(", ", result.Distinct().OrderBy(a=>a)));


            // Решение 2 - Кратко:
            var input = Console.ReadLine().Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var list = new List<string>();

            foreach (var word in input)
            {
                if (word.SequenceEqual(word.Reverse())) // !!!
                {
                    list.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", list.OrderBy(a => a).Distinct()));







            //    var cr = Console.ReadLine().Split();
            //    StringBuilder sb = new StringBuilder();
            //    var str = "1abcd 2efgh";
            //    for (int i = str.Length - 1; i >= 0; i--)
            //    {
            //        sb.Append(str[i]);
            //    }
            //var result= sb.ToString();
            //    Console.WriteLine(result);  // -> hgfe2 dcba1

        }
        }
    }
