using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Globalization;

namespace _01SoftuniCoffeeOrders
{
    class Program
    {
        static void Main()
        {

            var n = int.Parse(Console.ReadLine());
            var totalPrice = 0.0m;
            for (int i = 0; i < n; i++)
            {
               decimal unitPrice = decimal.Parse(Console.ReadLine());
               var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsules = long.Parse(Console.ReadLine());

                int month = orderDate.Month;
                int year = orderDate.Year;

               var daysInMonth = DateTime.DaysInMonth(year, month);
                var price = unitPrice*(daysInMonth * capsules);

                Console.WriteLine($"The price for the coffee is: ${price:0.00}");
                 totalPrice+= price;
            }

            Console.WriteLine($"Total: ${totalPrice:0.00}");
        }
    }
}
