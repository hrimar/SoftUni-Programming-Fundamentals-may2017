using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05KeyReplacer
{
    class KeyReplacer
    {
        static void Main()
        {
            // бре 33/100 ???
            var keysInput = Console.ReadLine();
            var regex = new Regex(@"\b(?<startKey>[a-zA-Z]+)(?<skip>[<\|]\w+\|)(?<endKey>[a-zA-Z]+)");
            var machedKeys = regex.Match(keysInput);
            var startKey = machedKeys.Groups["startKey"].Value;
            var endKey = machedKeys.Groups["endKey"].Value;

            var textLine = Console.ReadLine();
            var regexText = new Regex($@"{startKey}(?<eto>.+?){endKey}?");
            bool isMatched = regexText.IsMatch(textLine);
            //if (isMatched)
            //{
            var matchedText = regexText.Matches(textLine);

            foreach (Match item in matchedText)
            {
                if (item.Groups["eto"].Value== string.Empty)
                {
                    Console.WriteLine("Empty result");
                    break;
                }
                else
                    Console.Write(item.Groups["eto"].Value);
            }
            Console.WriteLine();
            //}
            //else
            //{

            //}
            //var matchedText = regexText.Match(textLine);
            //var result = string.Empty;
            //result+= matchedText.Groups[1].Value;
            //Console.WriteLine(result);
        }
    }
}
