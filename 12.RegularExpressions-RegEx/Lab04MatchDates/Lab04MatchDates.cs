using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab04MatchDates
{
    class Lab04MatchDates
    {
        static void Main()
        {
            // тъпака ot sajta ne priznava ?-te и групите са без имена:
            var pattern = @"\b(\d{2})([\/.-])(\w{3})\2(\d{4})\b";
            var dates = Console.ReadLine();
            var matches = Regex.Matches(dates, pattern);

            foreach (Match mach in matches) // Match!!!
            {           
                Console.WriteLine($"Day: {mach.Groups[1].Value}, Month: {mach.Groups[3]}, Year: {mach.Groups[4]}");
            }
        }
    }
}
