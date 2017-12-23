using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab02MatchPhoneNumber
{
    class Lab02MatchPhoneNumber
    {
        static void Main()
        {
            var phones = Console.ReadLine();
            var pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b"; //\+\d{3}( |-)2\1\d{3}\1\d{4}\b

            var matchedPhones = Regex.Matches(phones, pattern);

            // Вариант 1 с LINQ: !!!!!!!!!!!!!!!!!!!!!!!!!!!
            var castMatched = matchedPhones.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", castMatched));

            // Вариант 2:
            //var result = string.Empty;
            //foreach (Match number in matchedPhones)
            //{
            //    result += (number.Value + ", ");
            //}
            //result = result.TrimEnd(',', ' '); // !!!
            //Console.Write(result);
            //Console.WriteLine();
        }
    }
}
