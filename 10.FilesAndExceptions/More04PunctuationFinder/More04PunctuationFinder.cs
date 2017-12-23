using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace More04PunctuationFinder
{
    class More04PunctuationFinder
    {
        static void Main()
        {
            // Да се извадят във файл само тези символи ".,!?:" :
            var result = new List<char>();
            string input = File.ReadAllText("sample_text.txt");
            char[] separators = ".,!?:".ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < separators.Length; j++)
                {
                    if (separators[j] == input[i])
                    {
                        result.Add(separators[j]);
                    }
                }
            }
          var finalString=string.Join(", ", result);
            File.WriteAllText("output.txt", finalString);
        }
    }
}
