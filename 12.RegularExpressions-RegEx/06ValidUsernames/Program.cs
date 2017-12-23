using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _06ValidUsernames
{
    class Program
    {
        static void Main()
        {
            // 66/100
            //            string[] separators = Regex.Split(@" /\().");

            char[] separators = @" /\().".ToCharArray();
            var input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var result = new List<string>();
            foreach (var username in input)
            {
                  var regex = new Regex(@"\b[a-zA-Z]\w{2,25}");
                var machedUser = regex.Match(username);
                if(machedUser.Success)
                {
                    result.Add(machedUser.ToString());
                }

            }
            //foreach (var res in result)
            //{
            //    var sum = 0;
            //    for (int i = 0; i < res.Length; i++)
            //    {
            //        sum += (int)res[i];
            //    }
            //}
            var final = result.OrderBy(a => a.Length);
            //Console.WriteLine(string.Join("\r\n", final));
            //Console.WriteLine();
            Console.WriteLine(result[result.Count - 2]);
            Console.WriteLine(result[result.Count-1]);
        }
    }
}
