using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _01SinoTheWalker
{
    class DateTimeExample
    {
        static void Main()
        {
            // Решение 5:
            var date= DateTime.Parse(Console.ReadLine());
            var steps = int.Parse(Console.ReadLine());
            var timeSeconds = int.Parse(Console.ReadLine());

            var secondsToAdd = (long)steps*timeSeconds;

            var secs = (int)secondsToAdd % 60;
            var mins = (int)(secondsToAdd / 60) % 60;
            var hours = (int)(secondsToAdd / 60 / 60) % 24;

            var resultDate = date.Add(new TimeSpan(hours, mins, secs));
            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", resultDate);

            // Решение 4:
           // var nums = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
           //long second = nums[2] + 60 * nums[1] + 60 * 60 * nums[0];
           // var secondsToAdd = long.Parse(Console.ReadLine())* long.Parse(Console.ReadLine());

           // second = second + secondsToAdd;
           // var secs = second % 60;
           // var min = (second / 60) % 60;
           // var hours = (second / 60 / 60) % 24;
           // Console.WriteLine($"Time Arrival: {hours:00}:{min:00}:{second:00}");

            // Решение 3: като умножим секундите, те са понякога толкова големи че правим от всички тях % (24*60*60)
            //така дори да превъртат дните нас не ни интересуват.Тогава вече можем да обавим секундите с AddSeconds()

            // Решение 2:
            // Всичко в секунди: sec + min*60 + hours*60*60; 
            // После добавяш новите секунди и накрая пак ги обръщаш в секунди с %60
            // минутите се получават още веднъж %60 и пак %60 за часовете

            // Решение 1: 100/100
            //var startTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

            //var steps = long.Parse(Console.ReadLine());
            //var stepsSeconds = long.Parse(Console.ReadLine());

            //long totalSeconds = (steps * stepsSeconds)+startTime.Second;
            //long minutes = startTime.Minute;
            //long hours = startTime.Hour;

            //if (totalSeconds > 3599)
            //{
            //    hours += totalSeconds / 3600;
            //    //minutes =
            //    totalSeconds = totalSeconds % 3600;
            //}
            //if (totalSeconds > 59)
            //{
            //    minutes += totalSeconds / 60;
            //    totalSeconds = totalSeconds % 60;

            //}
            //if(minutes>59)
            //{
            //    hours += minutes / 60;
            //    minutes = minutes % 60;
            //}
            //if(hours>23)
            //{
            //    hours = hours % 24;
            //}

            //Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{totalSeconds:00}");
        }
    }
}
