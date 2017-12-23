using System;

namespace More06CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            long result = long.MinValue;
            long max = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                string num = (Console.ReadLine());

                if (type == "sbyte") //num < sbyte.MaxValue
                {
                    try
                    {
                        result = sbyte.Parse(num);
                    }
                    catch { }
                }
                else if (type == "int")//&& num < int.MaxValue
                {
                    try
                    {
                        result = int.Parse(num);
                    }
                    catch     {   }
                }
                else if (type == "long")//&& num < long.MaxValue
                {
                    try
                    {
                        result = long.Parse(num);
                    }
                    catch { }
                }

                max = Math.Max(max, result);
                //if (result>max)
                //{
                //    max = result;
                //}
            }
            Console.WriteLine(max);

    // Извод: като не знаеш какво ти подават го приемая като стринг и го TryParse или Cry-Catch!!!            // довърши, taka e 71/100!
            //string type = Console.ReadLine();
            //int n = int.Parse(Console.ReadLine());

            //long result = long.MinValue;
            //long max = long.MinValue;

            //for (int i = 0; i < n; i++)
            //{                
            //    long num = long.Parse(Console.ReadLine());

            //   if(type=="sbyte" && num < sbyte.MaxValue)
            //    {
            //        result = num;
            //    }
            //    else if (type == "int" && num < int.MaxValue)
            //    {
            //        result = num;
            //    }
            //    else  if (type == "long" && num < long.MaxValue)
            //    {
            //        result = num;
            //    }

            //    max = Math.Max(max, result);
            //    //if (result>max)
            //    //{
            //    //    max = result;
            //    //}
            //}


            //Console.WriteLine(max);

        }
    }
}
