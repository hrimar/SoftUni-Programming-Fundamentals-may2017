using System;
using System.Collections.Generic;

namespace More05WeatherForecast
{
    class Program
    {
        static void Main()
        {
            // Хитро авторско решение:
            string numberString = Console.ReadLine();
            try
            {
                sbyte.Parse(numberString);
                Console.WriteLine("Sunny");
            }
            catch (Exception)
            {
                try
                {
                    int.Parse(numberString);
                    Console.WriteLine("Cloudy");
                }
                catch (Exception)
                {
                    try
                    {
                        long.Parse(numberString);
                        Console.WriteLine("Windy");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            decimal.Parse(numberString);
                            Console.WriteLine("Rainy");
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }

            // Това пак е 85/100, къде греша???
            //string n = Console.ReadLine();

            //try
            //{
            //    sbyte result = sbyte.Parse(n);
            //    Console.WriteLine("Sunny");
            //}
            //catch 
            //{
            //    try
            //    {
            //        int intResult = int.Parse(n);
            //    }
            //    catch (Exception)
            //    {
            //        try
            //        {
            //            long longResult = long.Parse(n);
            //            Console.WriteLine("Windy");
            //        }
            //        catch 
            //        {
            //            Console.WriteLine("Rainy");
            //        }
             
            //    }
            //}
     

            // Мое решение но 85/100:
            // decimal n = decimal.Parse(Console.ReadLine());

            // if (n % 1!= 0 && n < decimal.MaxValue && n > decimal.MinValue)
            // {
            //     Console.WriteLine("Rainy");
            // }
            // else if (n<sbyte.MaxValue && n>sbyte.MinValue)
            // {
            //     Console.WriteLine("Sunny");
            // }
            // else if (n < int.MaxValue && n > int.MinValue)
            // {
            //     Console.WriteLine("Cloudy");
            // }           
            //else if ( n < long.MaxValue && n > long.MinValue)
            // {
            //     Console.WriteLine("Windy");
            // }

        }
    }
}
