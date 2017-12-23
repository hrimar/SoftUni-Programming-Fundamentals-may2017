using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03RageQuit
{
    class Program
    {
        static void Main()
        {
            // Извод: Значи и string има ,Distinct() , а за StringBuilder се прави първо .ToString()!!!!!

            // Задача: от текст aSd2&5s@1 да се извадят всички символи преди числото 
            // и да с еповторят толкова пъти, колкото е числото, а после да се каже колко са уник. символи
            // при работа само със стринг гърми за време => StringBuilder!!!
            // так аот 20/100 стигаме до  90/100

            var input = Console.ReadLine().ToUpper();
            var pattern = new Regex(@"(?<word>[^0-9]+)(?<nums>[0-9]+)");

            var result = new StringBuilder();
            
            var matcheWords = pattern.Matches(input).Cast<Match>().ToArray();
            foreach (Match matchedWord  in matcheWords)
            {
                var word = matchedWord.Groups["word"].Value;
                var num = int.Parse(matchedWord.Groups["nums"].Value);

                for (int i = 0; i < num; i++)
                {
                    result.Append(word);
                }
            }
            // такива случай за уник символи, просто правим HashSet() и довабяме елементите, а в хеш сета се пазят само уник символи!
            Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
            Console.WriteLine(result);

            // побавното решение без Distinct за 90/100 с List  за резултата:

            //string strResult = result.ToString();
            //var unique = new List<char>();
            //strResult = strResult.ToUpper();

            //for (int i = 0; i < result.Length; i++)
            //{                
            //        if (!unique.Contains(strResult[i]))
            //        {
            //        unique.Add(strResult[i]);               
            //        }                
            //}
            //Console.WriteLine($"Unique symbols used: {unique.Count}");
            //Console.WriteLine(strResult);


            // такива случай за уник символи, просто правим HashSet() и довабяме елементите, а в хеш сета се пазят само уник символи!
            // имаме StringBuilder result:
            string output = result.ToString();
            var chars = new HashSet<char>();
            foreach (var ch in output)
            {
                chars.Add(ch);

            }
        }
    }
}
