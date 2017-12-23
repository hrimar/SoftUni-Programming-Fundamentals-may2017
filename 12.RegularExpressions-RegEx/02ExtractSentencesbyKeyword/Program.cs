using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02ExtractSentencesbyKeyword
{
    class Program
    {
        static void Main()
        {
            //80/100
            var substringWord = Console.ReadLine();
            // 1. Сплит с Lambda:
            //var separators = ".?!".ToCharArray();
            //var texts = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //2. Split  с Regex:
            string textsstrings = Console.ReadLine();
            string[]texts = Regex.Split(textsstrings, @"[.!?]");

            foreach (var text in texts)
            {
                var pattern = $@"\b.* {substringWord} .*\b";
                var matchesWords = Regex.Matches(text, pattern);

                foreach (Match item in matchesWords)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
