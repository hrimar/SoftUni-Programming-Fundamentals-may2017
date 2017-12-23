using System;
using System.Collections.Generic;
using System.Linq;

namespace _06UserLogs
{
    class UserLogs
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var result = new SortedDictionary<string, Dictionary<string, int>> ();

            while (input != "end")
            {
                var count = 1;
                var ipMassageUser = input.Split().ToArray();
                var ips = ipMassageUser[0];
                var ip = ips.Substring(3, ips.Length-3);
                var massage = ipMassageUser[1];                
                var users = ipMassageUser[2];
                var user = users.Substring(5, users.Length - 5);

                if (!result.ContainsKey(user))
                {
                    result[user] = new Dictionary<string, int>();

                }

                if (!result[user].ContainsKey(ip))
                {
                    result[user][ip] = count;
                }
                else
                {
                    result[user][ip] += count;
                }

                input = Console.ReadLine();
            }

            //foreach (var res in result)// така не хем , хе, тоюка накрая!
            //{
            //    var user = res.Key;
            //    foreach (var item in res.Value)
            //    {
            //        var ip = item.Key;
            //        var counts = item.Value;

            //        Console.WriteLine($"{user}: {ip} => {counts},");
            //    }

            //}
            foreach (var res in result)
            {
                var user = res.Key;
                var output = new List<string>();

                foreach (var item in res.Value)
                {
                    var ip = item.Key;
                    var counts = item.Value;

                    output.Add($"{ip} => {counts}");
                    
                }
                Console.WriteLine($"{user}: \n"+string.Join(", ", output)+".");
            }
        }
    }
}
