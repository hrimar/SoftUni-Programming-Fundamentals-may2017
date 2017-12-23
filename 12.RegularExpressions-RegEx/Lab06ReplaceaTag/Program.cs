using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab06ReplaceaTag
{
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            var replacement = @"[URL href=$1]$2[/URL]";

            while (text != "end")
            {
                var replace = Regex.Replace(text, pattern, replacement);
                Console.WriteLine(replace);
                text = Console.ReadLine();
            }

        }
    }
}
