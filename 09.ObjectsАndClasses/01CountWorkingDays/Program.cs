using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _01CountWorkingDays
{   
    class Program
    {
        static void Main()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(str1, "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(str2, "d-M-yyyy", CultureInfo.InvariantCulture);

            var hollidays = new DateTime[11]
            {
             new DateTime(2016, 1, 1),              new DateTime(2016, 3, 3),
               new DateTime(2016, 5, 1),                 new DateTime(2016, 5, 6),
                   new DateTime(2016, 5, 24),                     new DateTime(2016, 9, 6),
                       new DateTime(2016, 9, 22),                         new DateTime(2016, 11, 1),
                           new DateTime(2016, 12, 24),                            new DateTime(2016, 12, 25),
                               new DateTime(2016, 12, 26)
            };
            var count = 0;
            for (DateTime day = startDate; day <= endDate; day.AddDays(1))
            {
                DateTime temp = new DateTime(2016, day.Month, day.Day); // за да гледа само деня и месеца!!!

                if (!(hollidays.Contains(temp) || day.DayOfWeek == DayOfWeek.Sunday || day.DayOfWeek == DayOfWeek.Saturday))
                {
                    count++;
                }

                day=day.AddDays(1);
            }
            Console.WriteLine(count);
        }
    }
}
