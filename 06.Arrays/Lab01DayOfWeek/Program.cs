using System;
using System.Linq;


namespace Lab01DayOfWeek
{
    class Program
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());

            string[] days = new string[]
            {                
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            for (int i = 0; i < days.Length; i++)
            {
                if(i==day-1)
                {
                    Console.WriteLine(days[i]);
                }                
            }
            if(day<=0 || day>7)
            {             
                    Console.WriteLine("Invalid Day!");
            }
        }
    }
}
