using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace More01Censorship
{
    class Program
    {
        static void Main()
        {
            // да се замени всяка дума-шаблон в долното изречение с "*"-ки:
            var word = Console.ReadLine();
            var sentence = Console.ReadLine();

           var result=sentence.Replace(word, new string('*', word.Length));
            Console.WriteLine(result);
        }
    }
}
