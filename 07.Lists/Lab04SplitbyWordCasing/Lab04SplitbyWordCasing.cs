using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab04SplitbyWordCasing
{
    class Lab04SplitbyWordCasing
    {
        static void Main()
        {
            char[] separators = ", ; : . ! ( ) \" ' \\ / [ ] ".ToCharArray();
            var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
           
            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();
                       
            foreach (var word in words)
            {
                var lowerCounter = 0;
                var upperCounter = 0;

                foreach (var symbol in word)
                {
                    if(char.IsLower(symbol))
                    {
                        lowerCounter++;
                    }
                    else if (char.IsUpper(symbol))
                    {
                        upperCounter++;
                    }
                  
                }
                if (lowerCounter == word.Length)
                {
                    lowerCase.Add(word);
                }
                else if (upperCounter == word.Length)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
