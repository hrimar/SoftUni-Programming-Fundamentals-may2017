using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab05MatchNumbers
{
    class Lab05MatchNumbers
    {
        static void Main()
        {
            // whitespace before it or the end of the string (^|(?<=\s)) ???
            //(match either $ or what’s called a positive lookahead). ???

            var numbers = Console.ReadLine();
            var pattern = @"(^|\s)-?(\d+)\.?(\d*)($|(?=\s))";
            var machedNums = Regex.Matches(numbers, pattern);

            foreach (Match n in machedNums)
            {
                Console.Write(n+"");
            }
            Console.WriteLine();
        }
    }
}
