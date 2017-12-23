using System;
using System.Collections.Generic;
using System.Linq;

namespace _08LogsAggregator
{
    class LogsAggregator
    {
        static void Main()
        {           
            var n = int.Parse(Console.ReadLine());
            var result = new SortedDictionary<string, SortedDictionary<string, int>>();// key-name, key-ip value-duration

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                var ip = input[0];
                var name = input[1];
                var duration = int.Parse(input[2]);

                if (!result.ContainsKey(name))
                {
                    result[name] = new SortedDictionary<string, int>();
                }
                if(!result[name].ContainsKey(ip))
                {
                    result[name][ip] = duration;
                }
                else
                {
                    result[name][ip] += duration;
                }
            }
           
            foreach (var nameIP in result)
            {                
                var name = nameIP.Key;
                var duration = 0;
                var ips = string.Empty;
                
                    var ip = nameIP.Value.Keys;
                    duration = nameIP.Value.Values.Sum();
                    
                    ips = string.Join(", ", ip);
                    Console.WriteLine($"{name}: {duration} [{ips}]");   
            }
            
        }
    }
}
