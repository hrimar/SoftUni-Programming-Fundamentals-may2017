using System;

namespace Lab06TheatrePromotion
{
    class Program
    {
        static void Main()
        {
            var day = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());

            CheckingDayAndAge(day, age);
        }

        private static void CheckingDayAndAge(string day, int age)
        {
            var price = -1;
            var is12 = (day == "weekday" && age >= 0 && age <= 18) ||
                (day == "holiday" && age > 18 && age <= 64) ||
                (day == "weekday" && age > 64 && age <= 122);
            var is15 = (day == "weekend" && age >= 0 && age <= 18) ||
               (day == "weekend" && age > 64 && age <= 122);

            if (is12)
            {
                price = 12;
            }
            else if (is15)
            {
                price = 15;
            }
            else if ((day == "holiday" && age >= 0 && age <= 18))
            {
                price = 5;
            }
            else if ((day == "weekend" && age > 18 && age <= 64))
            {
                price = 20;
            }
            else if ((day == "weekday" && age > 18 && age <= 64))
            {
                price = 18;
            }
            else if ((day == "holiday" && age > 64 && age <= 122))
            {
                price = 10;
            }
            else
            {
                Console.WriteLine("Error!");
            }
            if (price != -1)
                Console.WriteLine($"{price}$");
        }
    }
}
