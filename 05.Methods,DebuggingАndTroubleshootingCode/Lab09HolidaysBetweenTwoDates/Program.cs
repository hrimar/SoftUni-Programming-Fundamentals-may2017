using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab09HolidaysBetweenTwoDates
{
    class Program
    {
        static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            var startDate = DateTime.ParseExact(firstDate, "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(secondDate, "d.M.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;
            for (var date = startDate; date <= endDate; date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;

                }
                date = date.AddDays(1);
            }              

            Console.WriteLine(holidaysCount);
        }

    }
}
