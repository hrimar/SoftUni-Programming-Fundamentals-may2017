using System;

namespace _04Hotel
{
    class Program
    {
        static void Main()
        {

            var month = Console.ReadLine().ToLower();
            var nights = int.Parse(Console.ReadLine());
            var levaPerNight = -1;
            var discount = 0;
            var studioLeva = -1.0;
            var doubleLeva = -1.0;
            var suiteLeva = -1.0;

          if (month=="october" || month=="may")
            {
                studioLeva = 50.0*nights;
                doubleLeva = 65.0*nights;
                suiteLeva = 75.0*nights;
                if(nights>7)
                {                    
                    if (month == "october")
                    {
                        studioLeva = 50.0 * (nights-1);
                    }
                    studioLeva = (studioLeva - (studioLeva * 5) / 100.0);
                }               
            }
            else if (month == "june" || month == "september")
            {
                studioLeva = 60.0 * nights;
                doubleLeva = 72.0 * nights;
                suiteLeva = 82.0 * nights;
                if (month == "september" && nights>7)
                {
                    studioLeva = 60.0 * (nights - 1);
                }
                if (nights > 14)
                {
                    
                    doubleLeva = (doubleLeva - (doubleLeva * 10) / 100.0);
                }
            }
            else if (month == "july" || month == "august" || month=="december")
            {
                studioLeva = 68.0 * nights;
                doubleLeva = 77.0 * nights;
                suiteLeva = 89.0 * nights;
                if (nights > 14)
                {
                    suiteLeva = (suiteLeva - (suiteLeva * 15) / 100.0) ;
                }
            }
            Console.WriteLine($"Studio: {studioLeva:f2} lv.");
            Console.WriteLine($"Double: {doubleLeva:f2} lv.");
            Console.WriteLine($"Suite: {suiteLeva:f2} lv.");
        }
    }
}
