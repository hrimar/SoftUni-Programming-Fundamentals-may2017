using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03Regexmon
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var didiPatern = @"[^a-zA-Z-]+";
            var bojoPatern = @"[a-zA-Z]+-[a-zA-Z]+";
            var didiMatch = string.Empty;

            while (input.Length > 0)
            {
                didiMatch = Regex.Match(input, didiPatern).ToString();
                //ако няма вече матч!!!
                bool isMatchedDidi = Regex.IsMatch(input, didiPatern);
                if (isMatchedDidi)
                {
                    var startIndexDidi = input.IndexOf(didiMatch);
                    //input = input.Remove(startIndexDidi, didiMatch.Length);
                   input=input.Substring(startIndexDidi+didiMatch.Length);
                    
                    Console.WriteLine(didiMatch);
                }
                
                var bojoMatch = Regex.Match(input, bojoPatern).ToString();
                bool isMatchedBojo = Regex.IsMatch(input, bojoPatern);
                if(isMatchedBojo)
                {
                //input = input.Replace(bojoMatch, "");
                var startIndexBojo = input.IndexOf(bojoMatch);
                    //input = input.Remove(startIndexBojo, bojoMatch.Length);
                    input = input.Substring(startIndexBojo+bojoMatch.Length);
                    Console.WriteLine(bojoMatch);
                }
                if(isMatchedDidi==false && isMatchedBojo==false)
                {
                    break;
                }

            }




        }
    }
}
