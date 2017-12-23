using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace More05OnlyLetters
{
    class Program
    {
        static void Main()
        {
            // бре пак 83/100 ???
            var input = Console.ReadLine();
            var regex = new Regex(@"(?<digit>[0-9]+)(?<letter>[a-zA-Z])");

            var matchedText = regex.Matches(input);
            
            var result = "";
            foreach (Match item in matchedText)
            {
                //Console.WriteLine(item);
                var text = item.ToString();
                var digit = item.Groups["digit"].ToString();
                var letter = item.Groups["letter"].ToString();
            result = input.Replace(digit, letter);
                result = result.Replace(digit, letter);
                input = result;
            
            }
    Console.WriteLine(result);
            
        }
    }
}
