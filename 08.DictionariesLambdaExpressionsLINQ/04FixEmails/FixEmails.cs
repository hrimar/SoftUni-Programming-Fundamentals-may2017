using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FixEmails
{
    class FixEmails
    {
        static void Main()
        {
            // 1. Решение с LINQ:
            var name = Console.ReadLine();
            var result = new Dictionary<string, string>();

            while (name != "stop")
            {
                var email = Console.ReadLine();

                    result[name] = email;
             

                name = Console.ReadLine();
            }

            var final = result.Where(kvp => !(kvp.Value.EndsWith("us") || kvp.Value.EndsWith("uk")))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var item in result)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }

            // 2. Мое традиционно решение 100/100:
            //var name = Console.ReadLine();
            //var result = new Dictionary<string, string>();

            //while (name!="stop")
            //{
            //    var email = Console.ReadLine();

            //    if((!email.EndsWith("us")) && (!email.EndsWith("uk")) &&
            //        (!email.EndsWith("US")) && (!email.EndsWith("UK")))
            //    {
            //        result[name] = email;
            //    }

            //    name = Console.ReadLine();
            //}

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key + " -> " + item.Value);
            //}
        }
    }
}
