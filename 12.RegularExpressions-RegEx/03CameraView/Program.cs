using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03CameraView
{
    class Program
    {
        static void Main()
        {
            // 83/100
            var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var skipElem = elements[0];
            var takeElem = elements[1];

            //var separators = " |<".ToCharArray();
            //var textLine = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //foreach (var text in textLine)
            //{
            //    var result = new string(text.Skip(skipElem).Take(takeElem).ToArray());
            //    Console.WriteLine(result);
            //}

            // var pattern = @"(?<=\|<)(\w+)";*/ // (?<=\|<)\w+
            var pattern = @"(?<=\|<)\w+";
            var text = Console.ReadLine();
            var machedText = Regex.Matches(text, pattern);

                       
            var result = machedText.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            var final = new List<string>();
            foreach (var res in result)
            {                
                var fin = res.Remove(0, skipElem);
                final.Add(fin);
            }
           
            Console.WriteLine(string.Join(", ", final));
        }
    }
}
