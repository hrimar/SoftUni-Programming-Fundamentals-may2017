using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            var text = Console.ReadLine().ToCharArray();
           var result=text.Select(c => (int)c).Select(c => $@"\u{c:x4}");
            string final = string.Empty;
            foreach (var item in result)
            {
                final += item;
            }
            Console.WriteLine(final);

            // Решение 2:
            //var text = Console.ReadLine().ToCharArray();
            //foreach (var item in text)
            //{
            //    var result = (int)item;
            //    var res = $@"\u{result:x4}";
            //    Console.Write(res);
            //}
            //Console.WriteLine();
        }
        }
}
