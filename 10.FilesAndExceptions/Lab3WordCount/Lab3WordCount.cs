using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Lab3WordCount
{
    class Lab3WordCount
    {
        static void Main()
        {
   // Колко пъти се среща всяка дума от файл words.txt в файл input.txt: !!!
            var words = File.ReadAllText("words.txt").Split();
            
            var result = new Dictionary<string, int>();
            foreach (var w in words)
            {
                if(!result.ContainsKey(w))
                {
                    result[w] = 1;
                }
            }
            var readedText = File.ReadAllText("input.txt").ToLower().Split();
            foreach (var word in readedText)
            {
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
                
            }
            foreach (var res in result.OrderByDescending(s=>s.Value))
            {
                Console.WriteLine(res.Key+" - "+res.Value);
            }

            // Tрябва Дикт да се запише в масив: !!!
            var resultArr = result.Select((r, index)=> r.Key + " - " + r.Value).ToArray();
            
            File.WriteAllLines("Output.txt", resultArr);
        }
    }
}
