using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main()
        {
            var regex = new Regex(@"(<p>)(?<message>.+?)(<\/p>)");
            var input = Console.ReadLine();
            var paragraphs = regex.Matches(input).Cast<Match>()
                .Select(a => a.Groups["message"].Value);  // взима само тази група!
             //   .Select(a => Regex.Replace(a, @"[^a-z\d]+", " ")); 
                                                         //
           var replacedParagrphs = paragraphs.Select(a=>Regex.Replace(a, @"[^a-z\d]+", " "));
            //т.е. заменяма всичко което не е малка буква или число ([^a-z\d]+) с " " !!!
            
            var finalReplace=replacedParagrphs.Select(a => Regex.Replace(a, @"\s+", " ")).ToArray(); // замяна на всички " " с една!

            // остава всяка буква да се завърти с 13 символа на дясно:
            for (int i = 0; i < finalReplace.Length; i++)
            {
                finalReplace[i]=Rod13String(finalReplace[i]);
            }

            var result = new StringBuilder();
            foreach (var item in finalReplace)
            {
                result.Append(item);
            }
            Console.WriteLine(result.ToString());
        }

        private static string Rod13String(string newInput)
        {
            var result = new StringBuilder();

            foreach (var letter in newInput)
            {
                result.Append(Rod13(letter));
            }

            return result.ToString();
        }

        private static char Rod13(char letter) // за въртене на всяка буква
        {
            // за проверка дали чара е буква, цифра или шпация:
          if(!char.IsLetter(letter)) // ако не е буква - прескачаме
            {
                return letter;
            }

            var offset = char.IsUpper(letter) ? 'A' : 'a'; // излишно

            char rotatedLetter = (char) ((letter - offset+13) % 26 + offset);

            return rotatedLetter;
        }
    }
}
