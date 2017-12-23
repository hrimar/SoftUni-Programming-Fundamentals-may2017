using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01ExtractEmails
{
    class Program
    {
        static void Main()
        {
            //70/100 ??/            
            //var pattern = @"\b([a-z0-9]+)(\.|-)?(\w+)@([a-z]+)\2\w*(\.*)([a-z]+)\b";

            // 100/100:
            var pattern = @"(?<=\s)[a-z0-9]+([.-]\w*)*@[a-z0-9]+([.-]\w*)*(\.[a-z]+)\b";
            var text = Console.ReadLine();
            var matchedMails = Regex.Matches(text, pattern);

            foreach (Match mail in matchedMails)
            {
                Console.WriteLine(mail);
            }
        }
    }
}
