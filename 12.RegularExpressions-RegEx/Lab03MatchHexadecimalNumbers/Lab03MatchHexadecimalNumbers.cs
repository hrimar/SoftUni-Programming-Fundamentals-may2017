using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab03MatchHexadecimalNumbers
{
    class Lab03MatchHexadecimalNumbers
    {
        static void Main()
        {
            var patern = @"\b(0x)?[0-9A-F]+\b";
            var text = Console.ReadLine();
            var maches = Regex.Matches(text, patern);
            var opit = maches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(" ", opit));



        }
    }
}
