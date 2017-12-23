using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Lab01DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            var input = Console.ReadLine();
            DateTime data = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            var output = data.DayOfWeek;
            Console.WriteLine(output);
        }
    }
}
